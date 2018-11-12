/* The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "AbstractGroup.java".  Description: 
/// "A partial implementation of Group" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  �GPL�), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
 * */
using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Log;
using System.Collections.Generic;

namespace NHapi.Base.Model
{


    /// <summary> A partial implementation of Group.  Subclasses correspond to specific
    /// groups of segments (and/or other sub-groups) that are implicitly defined by message structures  
    /// in the HL7 specification.  A subclass should define it's group structure by putting repeated calls to 
    /// the add(...) method in it's constructor.  Each call to add(...) adds a specific component to the 
    /// Group.  
    /// </summary>
    /// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
    /// </author>
    public abstract class AbstractGroup : IGroup
    {
        private List<AbstractGroupItem> _items;
        private IGroup parentStructure;
        private IModelClassFactory myFactory;
        private static readonly IHapiLog log;

        static AbstractGroup()
        {
            log = HapiLogFactory.GetHapiLog(typeof(AbstractGroup));
        }

        /// <summary>
        /// Gets a group item by name
        /// </summary>
        /// <param name="name">The name of the group item</param>
        /// <returns>Group item if found, null otherwise</returns>
        protected AbstractGroupItem GetGroupItem(string name)
        {
            AbstractGroupItem ret = null;
            foreach (AbstractGroupItem item in _items)
            {
                if (item.Name.Equals(name))
                {
                    ret = item;
                    break;
                }
            }
            return ret;
        }

        /// <summary>
        /// A string[] of group names
        /// </summary>
        virtual public System.String[] Names
        {
            get
            {
                System.String[] retVal = new System.String[_items.Count];
                for (int i = 0; i < _items.Count; i++)
                {
                    AbstractGroupItem item = _items[i];
                    retVal[i] = item.Name;
                }
                return retVal;
            }

        }
        /// <summary> Returns the Message to which this segment belongs.</summary>
        virtual public IMessage Message
        {
            get
            {
                IStructure s = this;
                while (!typeof(IMessage).IsAssignableFrom(s.GetType()))
                {
                    s = s.ParentStructure;
                }
                return (IMessage)s;
            }

        }
        /// <summary>Returns the parent group within which this structure exists (may be root
        /// message group).
        /// </summary>
        virtual public IGroup ParentStructure
        {
            get
            {
                return this.parentStructure;
            }

        }

        /// <summary> This constructor should be used by implementing classes that do not 
        /// also implement Message.
        /// 
        /// </summary>
        /// <param name="parentStructure">the group to which this Group belongs.
        /// </param>
        /// <param name="factory">the factory for classes of segments, groups, and data types under this group
        /// </param>
        protected internal AbstractGroup(IGroup parentStructure, IModelClassFactory factory)
        {
            this.parentStructure = parentStructure;
            this.myFactory = factory;
            init();
        }

        /// <summary> This constructor should only be used by classes that implement Message directly.
        /// 
        /// </summary>
        /// <param name="factory">the factory for classes of segments, groups, and data types under this group
        /// </param>
        protected internal AbstractGroup(IModelClassFactory factory)
        {
            this.myFactory = factory;
            init();
        }

        private void init()
        {
            _items = new List<AbstractGroupItem>();
        }

        /// <summary> Returns the named structure.  If this Structure is repeating then the first 
        /// repetition is returned.  Creates the Structure if necessary.  
        /// </summary>
        /// <throws>  HL7Exception if the named Structure is not part of this Group.  </throws>
        public virtual IStructure GetStructure(System.String name)
        {
            return GetStructure(name, 0);
        }

        /// <summary> Returns a particular repetition of the named Structure. If the given repetition
        /// number is one greater than the existing number of repetitions then a new  
        /// Structure is created.  
        /// </summary>
        /// <throws>  HL7Exception if the named Structure is not part of this group,  </throws>
        /// <summary>    if the structure is not repeatable and the given rep is > 0,  
        /// or if the given repetition number is more than one greater than the 
        /// existing number of repetitions.  
        /// </summary>
        public virtual IStructure GetStructure(System.String name, int rep)
        {
            AbstractGroupItem item = GetGroupItem(name);

            if (item == null)
                throw new HL7Exception(name + " does not exist in the group " + this.GetType().FullName, HL7Exception.APPLICATION_INTERNAL_ERROR);

            IStructure ret;
            if (rep < item.Structures.Count)
            {
                // return existng Structure if it exists 
                ret = item.Structures[rep];
            }
            else if (rep == item.Structures.Count)
            {
                //verify that Structure is repeating ... 
                bool repeats = item.IsRepeating;
                if (!repeats && item.Structures.Count > 0)
                    throw new HL7Exception("Can't create repetition #" + rep + " of Structure " + name + " - this Structure is non-repeating", HL7Exception.APPLICATION_INTERNAL_ERROR);

                //create a new Structure, add it to the list, and return it
                System.Type classType = item.ClassType;
                ret = tryToInstantiateStructure(classType, name);
                item.Structures.Add(ret);
            }
            else
            {
                throw new HL7Exception("Can't return repetition #" + rep + " of " + name + " - there are only " + _items.Count + " repetitions.", HL7Exception.APPLICATION_INTERNAL_ERROR);
            }
            return ret;
        }

        /// <summary> Expands the group definition to include a segment that is not 
        /// defined by HL7 to be part of this group (e.g. an unregistered Z segment). 
        /// The new segment is slotted at the end of the group.  Thenceforward if 
        /// such a segment is encountered it will be parsed into this location. 
        /// If the segment name is unrecognized a GenericSegment is used.  The 
        /// segment is defined as repeating and not required.  
        /// </summary>
        public virtual System.String addNonstandardSegment(System.String name)
        {
            System.String version = this.Message.Version;
            if (version == null)
                throw new HL7Exception("Need message version to add segment by name; message.getVersion() returns null");
            System.Type c = myFactory.GetSegmentClass(name, version);
            if (c == null)
                c = typeof(GenericSegment);

            int index = this.Names.Length;

            tryToInstantiateStructure(c, name); //may throw exception

            return insert(c, false, true, index, name);
        }

        /// <summary> Adds a new Structure (group or segment) to this Group.  A place for the  
        /// Structure is added to the group but there are initially zero repetitions.  
        /// This method should be used by the constructors of implementing classes 
        /// to specify which Structures the Group contains - Structures should be 
        /// added in the order in which they appear.  
        /// Note that the class is supplied instead of an instance because we want 
        /// there initially to be zero instances of each structure but we want the 
        /// AbstractGroup code to be able to create instances as necessary to support
        /// get(...) calls.
        /// </summary>
        /// <returns> the actual name used to store this structure (may be appended with 
        /// an integer if there are duplicates in the same Group).  
        /// </returns>
        protected internal virtual System.String add(System.Type c, bool required, bool repeating)
        {
            System.String name = getStructureName(c);

            return insert(c, required, repeating, _items.Count, name);
        }

        /// <summary> Inserts the given structure into this group, at the
        /// indicated index number.  This method is used to support handling 
        /// of unexpected segments (e.g. Z-segments).  In contrast, specification 
        /// of the group's normal children should be done at construction time, using the 
        /// add(...) method. 
        /// </summary>
        private System.String insert(System.Type classType, bool required, bool repeating, int index, System.String name)
        {
            //see if there is already something by this name and make a new name if necessary ... 
            if (nameExists(name))
            {
                int version = 2;
                System.String newName = name;
                while (nameExists(newName))
                {
                    newName = name + version++;
                }
                name = newName;
            }

            AbstractGroupItem item = new AbstractGroupItem(name, required, repeating, classType);
            _items.Insert(index, item);
            return name;
        }

        /// <summary> Returns true if the class name is already being used. </summary>
        private bool nameExists(System.String name)
        {
            bool exists = false;
            AbstractGroupItem item = GetGroupItem(name);
            if (item != null)
                exists = true;
            return exists;
        }

        /// <summary> Attempts to create an instance of the given class and return 
        /// it as a Structure. 
        /// </summary>
        /// <param name="c">the Structure implementing class
        /// </param>
        /// <param name="name">an optional name of the structure (used by Generic structures; may be null)
        /// </param>
        private IStructure tryToInstantiateStructure(System.Type c, System.String name)
        {
            IStructure s = null;
            try
            {
                System.Object o = null;
                if (typeof(GenericSegment).IsAssignableFrom(c))
                {
                    s = new GenericSegment(this, name);
                }
                else if (typeof(GenericGroup).IsAssignableFrom(c))
                {
                    s = new GenericGroup(this, name, myFactory);
                }
                else
                {
                    //first try to instantiate using contructor w/ Message arg ...
                    try
                    {
                        System.Type[] argClasses = new System.Type[] { typeof(IGroup), typeof(IModelClassFactory) };
                        System.Object[] argObjects = new System.Object[] { this, myFactory };
                        System.Reflection.ConstructorInfo con = c.GetConstructor(argClasses);
                        o = con.Invoke(argObjects);
                    }
                    catch (System.MethodAccessException)
                    {
                        o = System.Activator.CreateInstance(c);
                    }
                    if (!(o is IStructure))
                    {
                        throw new HL7Exception("Class " + c.FullName + " does not implement " + "ca.on.uhn.hl7.message.Structure", HL7Exception.APPLICATION_INTERNAL_ERROR);
                    }
                    s = (IStructure)o;
                }
            }
            catch (System.Exception e)
            {
                if (e is HL7Exception)
                {
                    throw (HL7Exception)e;
                }
                else
                {
                    throw new HL7Exception("Can't instantiate class " + c.FullName, HL7Exception.APPLICATION_INTERNAL_ERROR, e);
                }
            }
            return s;
        }

        /// <summary> Returns true if the named structure is required. </summary>
        public virtual bool IsRequired(System.String name)
        {
            AbstractGroupItem item = GetGroupItem(name);
            if (item == null)
                throw new HL7Exception("The structure " + name + " does not exist in the group " + this.GetType().FullName, HL7Exception.APPLICATION_INTERNAL_ERROR);
            return item.IsRequired;
        }

        /// <summary> Returns true if the named structure is required. </summary>
        public virtual bool IsRepeating(System.String name)
        {
            AbstractGroupItem item = GetGroupItem(name);
            if (item == null)
                throw new HL7Exception("The structure " + name + " does not exist in the group " + this.GetType().FullName, HL7Exception.APPLICATION_INTERNAL_ERROR);
            return item.IsRepeating;
        }

        /// <summary> Returns the number of existing repetitions of the named structure.</summary>
        public virtual int currentReps(System.String name)
        {
            AbstractGroupItem item = GetGroupItem(name);
            if (item == null)
                throw new HL7Exception("The structure " + name + " does not exist in the group " + this.GetType().FullName, HL7Exception.APPLICATION_INTERNAL_ERROR);
            return item.Structures.Count;
        }

        /// <summary> Returns an array of Structure objects by name.  For example, if the Group contains
        /// an MSH segment and "MSH" is supplied then this call would return a 1-element array 
        /// containing the MSH segment.  Multiple elements are returned when the segment or 
        /// group repeats.  The array may be empty if no repetitions have been accessed
        /// yet using the get(...) methods. 
        /// </summary>
        /// <throws>  HL7Exception if the named Structure is not part of this Group.  </throws>
        public virtual IStructure[] GetAll(System.String name)
        {
            AbstractGroupItem item = GetGroupItem(name);
            if (item == null)
                throw new HL7Exception("The structure " + name + " does not exist in the group " + this.GetType().FullName, HL7Exception.APPLICATION_INTERNAL_ERROR);
            IStructure[] all = new IStructure[item.Structures.Count];
            for (int i = 0; i < item.Structures.Count; i++)
            {
                all[i] = item.Structures[i];
            }
            return all;
        }

        /// <summary> Returns the Class of the Structure at the given name index.  </summary>
        public virtual System.Type GetClass(System.String name)
        {
            AbstractGroupItem item = GetGroupItem(name);
            return item.ClassType;
        }

        /// <summary> Returns the class name (excluding package). </summary>
        public virtual System.String GetStructureName()
        {
            return getStructureName(this.GetType());
        }


        /// <summary>
        /// returns a name for a class of a Structure in this Message  
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private System.String getStructureName(System.Type c)
        {
            System.String fullName = c.FullName;
            int dotLoc = fullName.LastIndexOf('.');
            System.String name = fullName.Substring(dotLoc + 1, (fullName.Length) - (dotLoc + 1));

            //remove message name prefix from group names for compatibility with getters ...
            if (typeof(IGroup).IsAssignableFrom(c) && !typeof(IMessage).IsAssignableFrom(c))
            {
                System.String messageName = Message.GetStructureName();
                if (name.StartsWith(messageName) && name.Length > messageName.Length)
                {
                    name = name.Substring(messageName.Length + 1);
                }
            }

            return name;
        }



    }
}