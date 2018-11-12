/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "GroupGenerator.java".  Description: 
/// "Creates source code for Group classes - these are aggregations of 
/// segments and/or other groups that may repeat together within a message.
/// Source code is generated from the normative database" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s):  Eric Poiseau. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  �GPL�), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
using NHapi.Base;
using NHapi.Base.Log;

namespace NHapi.Base.SourceGeneration
{

    /// <summary> Creates source code for Group classes - these are aggregations of 
    /// segments and/or other groups that may repeat together within a message.
    /// Source code is generated from the normative database.  
    /// 
    /// </summary>
    /// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
    /// </author>
    /// <author>  Eric Poiseau
    /// </author>
    public class GroupGenerator : System.Object
    {
        private static readonly IHapiLog log;

        /// <summary>Creates new GroupGenerator </summary>
        public GroupGenerator()
        {
        }

        /// <summary> Creates source code for a Group and returns a GroupDef object that 
        /// describes the Group's name, optionality, repeatability.  The source 
        /// code is written under the given directory.
        /// The structures list may contain [] and {} pairs representing 
        /// nested groups and their optionality and repeastability.  In these cases
        /// this method is called recursively.
        /// If the given structures list begins and ends with repetition and/or 
        /// optionality markers the repetition and optionality of the returned 
        /// GroupDef are set accordingly.  
        /// <param name="structures">a list of the structures that comprise this group - must 
        /// be at least 2 long
        /// </param>
        /// <param name="groupName">The group name</param>
        /// <param name="version">The version of message</param>
        /// <param name="baseDirectory">the directory to which files should be written
        /// </param>
        /// <param name="message">the message to which this group belongs
        /// </param>
        /// <throws>  HL7Exception if the repetition and optionality markers are not  </throws>
        /// </summary>
        public static GroupDef writeGroup(IStructureDef[] structures, System.String groupName, System.String baseDirectory, System.String version, System.String message)
        {

            //make base directory
            if (!(baseDirectory.EndsWith("\\") || baseDirectory.EndsWith("/")))
            {
                baseDirectory = baseDirectory + "/";
            }
            System.IO.FileInfo targetDir = SourceGenerator.makeDirectory(baseDirectory + PackageManager.GetVersionPackagePath(version) + "Group");

            GroupDef group = getGroupDef(structures, groupName, baseDirectory, version, message);
            using (System.IO.StreamWriter out_Renamed = new System.IO.StreamWriter(targetDir.FullName + "/" + group.Name + ".cs"))
            {
                out_Renamed.Write(makePreamble(group, version));
                out_Renamed.Write(makeConstructor(group, version));

                IStructureDef[] shallow = group.Structures;
                for (int i = 0; i < shallow.Length; i++)
                {
                    out_Renamed.Write(makeAccessor(group, i));
                }
                out_Renamed.Write("}\r\n"); //Closing class
                out_Renamed.Write("}\r\n"); //Closing namespace
            }
            return group;
        }

        /// <summary> <p>Given a list of structures defining the deep content of a group (as provided in 
        /// the normative database, some being pairs of optionality and repetition markers
        /// and segments nested within) returns a GroupDef including a short list of the shallow contents of the 
        /// group (including segments and groups that are immediate children).</p> 
        /// <p>For example given MSH [PID PV1] {[ERR NTE]}, short list would be something like 
        /// MSH PID_GROUP ERR_GROUP (with PID_GROUP marked as optional and ERR_GROUP marked as 
        /// optional and repeating).</p>
        /// <p>This method calls writeGroup(...) where necessary in order to create source code for 
        /// any nested groups before returning corresponding GroupDefs.</p>
        /// </summary>
        public static GroupDef getGroupDef(IStructureDef[] structures, System.String groupName, System.String baseDirectory, System.String version, System.String message)
        {
            GroupDef ret = null;
            bool required = true;
            bool repeating = false;
            bool rep_opt = false;

            int len = structures.Length;
            IStructureDef[] shortList = new IStructureDef[len]; //place to put final list of groups/seg's w/o opt & rep markers
            int currShortListPos = 0;
            int currLongListPos = 0;

            try
            {
                //check for rep and opt (see if start & end elements are [] or {} AND they are each others' pair) ... 
                //System.out.println(len + " " + structures[0].getName() +structures[1].getName()+ ".." +structures[len-2].getName() + structures[len-1].getName()+ " " + message);
                if (optMarkers(structures[0].Name, structures[len - 1].Name) && (findGroupEnd(structures, 0) == len - 1))
                    required = false;
                if (repMarkers(structures[0].Name, structures[len - 1].Name) && (findGroupEnd(structures, 0) == len - 1))
                    repeating = true;
                if (repoptMarkers(structures[0].Name, structures[len - 1].Name) && (findGroupEnd(structures, 0) == len - 1))
                    rep_opt = true;
                if (repeating || !required)
                {
                    if (optMarkers(structures[1].Name, structures[len - 2].Name) && (findGroupEnd(structures, 1) == len - 2))
                        required = false;
                    if (repMarkers(structures[1].Name, structures[len - 2].Name) && (findGroupEnd(structures, 1) == len - 2))
                        repeating = true;
                }

                //loop through, recurse nested groups, and build short list of structures for this group
                int skip = 0;
                if (!required)
                    skip++;
                if (repeating)
                    skip++;
                if (rep_opt)
                    skip++;
                currLongListPos = skip;
                while (currLongListPos < len - skip)
                {
                    System.String currSegName = structures[currLongListPos].Name;
                    if (currSegName.Equals("[") || currSegName.Equals("{") || currSegName.Equals("[{"))
                    {
                        //this is the opening of a new group ... 
                        System.String name = ((SegmentDef)structures[currLongListPos]).GroupName;
                        int endOfNewGroup = findGroupEnd(structures, currLongListPos);
                        IStructureDef[] newGroupStructures = new IStructureDef[endOfNewGroup - currLongListPos + 1];
                        Array.Copy(structures, currLongListPos, newGroupStructures, 0, newGroupStructures.Length);
                        shortList[currShortListPos] = writeGroup(newGroupStructures, name, baseDirectory, version, message);
                        currLongListPos = endOfNewGroup + 1;
                    }
                    else
                    {
                        //copy verbatim into short list ... 
                        shortList[currShortListPos] = structures[currLongListPos];
                        currLongListPos++;
                    }
                    currShortListPos++;
                }
            }
            catch (System.ArgumentException e)
            {
                throw new HL7Exception("Problem creating nested group: " + e.GetType().FullName + ": " + e.Message, HL7Exception.APPLICATION_INTERNAL_ERROR);
            }

            if(rep_opt)
                ret = new GroupDef(message, groupName, false, true, "a Group object");
            else
                ret = new GroupDef(message, groupName, required, repeating, "a Group object");
            IStructureDef[] finalList = new IStructureDef[currShortListPos]; //note: incremented after last assignment
            Array.Copy(shortList, 0, finalList, 0, currShortListPos);
            for (int i = 0; i < finalList.Length; i++)
            {
                ret.addStructure(finalList[i]);
            }

            return ret;
        }

        /// <summary> Returns true if opening is "[{" and closing is "}]"</summary>
        private static bool repoptMarkers(System.String opening, System.String closing)
        {
            bool ret = false;
            if (opening.Equals("[{") && closing.Equals("}]"))
            {
                ret = true;
            }
            return ret;
        }


        /// <summary> Returns true if opening is "[" and closing is "]"</summary>
        private static bool optMarkers(System.String opening, System.String closing)
        {
            bool ret = false;
            if (opening.Equals("[") && closing.Equals("]"))
            {
                ret = true;
            }
            return ret;
        }

        /// <summary> Returns true if opening is "{" and closing is "}"</summary>
        private static bool repMarkers(System.String opening, System.String closing)
        {
            bool ret = false;
            if (opening.Equals("{") && closing.Equals("}"))
            {
                ret = true;
            }
            return ret;
        }

        /// <summary> Returns heading material for class source code (package, imports, JavaDoc, class
        /// declaration).
        /// </summary>
        public static System.String makePreamble(GroupDef group, System.String version)
        {
            System.Text.StringBuilder preamble = new System.Text.StringBuilder();
            preamble.Append("using NHapi.Base.Parser;\r\n");
            preamble.Append("using NHapi.Base;\r\n");
            preamble.Append("using NHapi.Base.Log;\r\n");
            preamble.Append("using System;\r\n");
            preamble.Append("using ");
            preamble.Append(PackageManager.GetVersionPackageName(version));
            preamble.Append("Segment;\r\n\r\n");
            preamble.Append("using NHapi.Base.Model;\r\n\r\n");
            preamble.Append("namespace ");
            preamble.Append(PackageManager.GetVersionPackageName(version));
            preamble.Append("Group\n");
            preamble.Append("{\r\n");
            preamble.Append("///<summary>\r\n");
            preamble.Append("///Represents the ");
            preamble.Append(group.Name);
            preamble.Append(" Group.  A Group is an ordered collection of message \r\n");
            preamble.Append("/// segments that can repeat together or be optionally in/excluded together.\r\n");
            preamble.Append("/// This Group contains the following elements: \r\n");
            preamble.Append(makeElementsDoc(group.Structures));
            preamble.Append("///</summary>\r\n");
            preamble.Append("[Serializable]\r\n");
            preamble.Append("public class ");
            preamble.Append(group.Name);
            preamble.Append(" : AbstractGroup {\r\n\r\n");
            return preamble.ToString();
        }


        /// <summary> Returns source code for the contructor for this Group class. </summary>
        public static System.String makeConstructor(GroupDef group, System.String version)
        {
            bool useFactory = NHapi.Base.ConfigurationSettings.UseFactory;

            System.Text.StringBuilder source = new System.Text.StringBuilder();

            source.Append("\t///<summary> \r\n");
            source.Append("\t/// Creates a new ");
            source.Append(group.Name);
            source.Append(" Group.\r\n");
            source.Append("\t///</summary>\r\n");
            source.Append("\tpublic ");
            source.Append(group.Name);
            source.Append("(IGroup parent, IModelClassFactory factory) : base(parent, factory){\r\n");
            source.Append("\t   try {\r\n");
            IStructureDef[] structs = group.Structures;
            int numStructs = structs.Length;
            for (int i = 0; i < numStructs; i++)
            {
                IStructureDef def = structs[i];

                if (def.Name.Equals("?"))
                {
                    source.Append("\t      this.addNonstandardSegment(\"ANY\");\r\n");
                }
                else
                {
                    if (useFactory)
                    {
                        source.Append("\t      this.add(factory.get");
                        source.Append((def is GroupDef) ? "Group" : "Segment");
                        source.Append("Class(\"");
                        source.Append(def.Name);
                        source.Append("\", \"");
                        source.Append(version);
                        source.Append("\"), ");
                    }
                    else
                    {
                        source.Append("\t      this.add(typeof(");
                        source.Append(def.Name);
                        source.Append("), ");
                    }

                    source.Append(def.Required.ToString().ToLower());
                    source.Append(", ");
                    source.Append(def.Repeating.ToString().ToLower());
                    source.Append(");\r\n");
                }
            }
            source.Append("\t   } catch(HL7Exception e) {\r\n");
            source.Append("\t      HapiLogFactory.GetHapiLog(GetType()).Error(\"Unexpected error creating ");
            source.Append(group.Name);
            source.Append(" - this is probably a bug in the source code generator.\", e);\r\n");
            source.Append("\t   }\r\n");
            source.Append("\t}\r\n\r\n");
            return source.ToString();
        }

        /// <summary> Returns source code for a JavaDoc snippet listing the contents of a Group 
        /// or Message.  
        /// </summary>
        public static System.String makeElementsDoc(IStructureDef[] structures)
        {
            System.Text.StringBuilder elements = new System.Text.StringBuilder();
            elements.Append("///<ol>\r\n");
            for (int i = 0; i < structures.Length; i++)
            {
                IStructureDef def = structures[i];
                elements.Append("///<li>");
                elements.Append(i);
                elements.Append(": ");
                elements.Append(def.Name);
                elements.Append(" (");
                elements.Append(def.Description);
                elements.Append(") ");
                if (!def.Required)
                    elements.Append("optional ");
                if (def.Repeating)
                    elements.Append("repeating");
                elements.Append("</li>\r\n");
            }
            elements.Append("///</ol>\r\n");
            return elements.ToString();
        }

        /// <summary> Returns source code for an accessor method for a particular Structure. </summary>
        public static System.String makeAccessor(GroupDef group, int structure)
        {
            System.Text.StringBuilder source = new System.Text.StringBuilder();

            IStructureDef def = group.Structures[structure];

            System.String name = def.Name;
            System.String indexName = group.getIndexName(name);
            System.String getterName = indexName;

            if (def is GroupDef)
            {
                System.String unqualifiedName = ((GroupDef)def).UnqualifiedName;
                getterName = group.getIndexName(unqualifiedName);
            }

            //make accessor for first (or only) rep ... 
            source.Append("\t///<summary>\r\n");
            source.Append("\t/// Returns ");
            if (def.Repeating)
                source.Append(" first repetition of ");
            source.Append(indexName);
            source.Append(" (");
            source.Append(def.Description);
            source.Append(") - creates it if necessary\r\n");
            source.Append("\t///</summary>\r\n");
            source.Append("\tpublic ");
            source.Append(def.Name);
            source.Append(" ");
            if (def.Repeating)
            {
                source.Append("Get");
                source.Append(getterName);
                source.Append("() {\r\n");
            }
            else
            {
                source.Append(getterName);
                source.Append(" { \r\n");
                source.Append("get{\r\n");
            }
            source.Append("\t   ");
            source.Append(def.Name);
            source.Append(" ret = null;\r\n");
            source.Append("\t   try {\r\n");
            source.Append("\t      ret = (");
            source.Append(def.Name);
            source.Append(")this.GetStructure(\"");
            source.Append(getterName);
            source.Append("\");\r\n");
            source.Append("\t   } catch(HL7Exception e) {\r\n");
            source.Append("\t      HapiLogFactory.GetHapiLog(GetType()).Error(\"Unexpected error accessing data - this is probably a bug in the source code generator.\", e);\r\n");
            source.Append("\t      throw new System.Exception(\"An unexpected error ocurred\",e);\r\n");
            source.Append("\t   }\r\n");
            source.Append("\t   return ret;\r\n");
            if (!def.Repeating)
                source.Append("\t}\r\n");
            source.Append("\t}\r\n\r\n");

            if (def.Repeating)
            {
                //make accessor for specific rep ... 
                source.Append("\t///<summary>\r\n");
                source.Append("\t///Returns a specific repetition of ");
                source.Append(indexName);
                source.Append("\r\n");
                source.Append("\t/// * (");
                source.Append(def.Description);
                source.Append(") - creates it if necessary\r\n");
                source.Append("\t/// throws HL7Exception if the repetition requested is more than one \r\n");
                source.Append("\t///     greater than the number of existing repetitions.\r\n");
                source.Append("\t///</summary>\r\n");
                source.Append("\tpublic ");
                source.Append(def.Name);
                source.Append(" Get");
                source.Append(getterName);
                source.Append("(int rep) { \r\n");
                source.Append("\t   return (");
                source.Append(def.Name);
                source.Append(")this.GetStructure(\"");
                source.Append(getterName);
                source.Append("\", rep);\r\n");
                source.Append("\t}\r\n\r\n");

                //make accessor for number of reps
                source.Append("\t/** \r\n");
                source.Append("\t * Returns the number of existing repetitions of ");
                source.Append(indexName);
                source.Append(" \r\n");
                source.Append("\t */ \r\n");
                source.Append("\tpublic int ");
                source.Append(getterName);
                source.Append("RepetitionsUsed { \r\n");
                source.Append("get{\r\n");
                source.Append("\t    int reps = -1; \r\n");
                source.Append("\t    try { \r\n");
                source.Append("\t        reps = this.GetAll(\"");
                source.Append(getterName);
                source.Append("\").Length; \r\n");
                source.Append("\t    } catch (HL7Exception e) { \r\n");
                source.Append("\t        string message = \"Unexpected error accessing data - this is probably a bug in the source code generator.\"; \r\n");
                source.Append("\t        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); \r\n");
                source.Append("\t        throw new System.Exception(message);\r\n");
                source.Append("\t    } \r\n");
                source.Append("\t    return reps; \r\n");
                source.Append("\t}\r\n");
                source.Append("\t} \r\n\r\n");
            }

            return source.ToString();
        }

        /// <summary> Given a list of structures and the position of a SegmentDef that 
        /// indicates the start of a group (ie "{" or "["), returns the position
        /// of the corresponding end of the group.  Nested group markers are ignored.  
        /// </summary>
        /// <throws>  IllegalArgumentException if groupStart is out of range or does not  </throws>
        /// <summary>      point to a group opening marker. 
        /// </summary>
        /// <throws>  HL7Exception if the end of the group is not found or if other pairs  </throws>
        /// <summary>      are not properly nested inside this one.  
        /// </summary>
        public static int findGroupEnd(IStructureDef[] structures, int groupStart)
        {

            //  {} is rep; [] is optionality
            System.String endMarker = null;
            try
            {
                System.String startMarker = structures[groupStart].Name;
                if (startMarker.Equals("["))
                {
                    endMarker = "]";
                }
                else if (startMarker.Equals("{"))
                {
                    endMarker = "}";
                }
                else if (startMarker.Equals("[{"))
                {
                    endMarker = "}]";
                }
                else
                {
                    log.Error("Problem starting at " + groupStart);
                    for (int i = 0; i < structures.Length; i++)
                    {
                        log.Error("Structure " + i + ": " + structures[i].Name);
                    }
                    throw new System.ArgumentException("The segment " + startMarker + " does not begin a group - must be [ or {");
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                throw new System.ArgumentException("The given start location is out of bounds");
            }

            //loop, increment and decrement opening and closing markers until we get back to 0 
            System.String segName = null;
            int offset = 0;
            try
            {
                int nestedInside = 1;
                while (nestedInside > 0)
                {
                    offset++;
                    segName = structures[groupStart + offset].Name;
                    if (segName.Equals("{") || segName.Equals("[") || segName.Equals("[{"))
                    {
                        nestedInside++;
                    }
                    else if (segName.Equals("}") || segName.Equals("]") || segName.Equals("}]"))
                    {
                        nestedInside--;
                    }
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                throw new HL7Exception("Couldn't find end of group", HL7Exception.APPLICATION_INTERNAL_ERROR);
            }
            if (!endMarker.Equals(segName))
                throw new HL7Exception("Group markers are not nested properly", HL7Exception.APPLICATION_INTERNAL_ERROR);
            return groupStart + offset;
        }
        static GroupGenerator()
        {
            log = HapiLogFactory.GetHapiLog(typeof(GroupGenerator));
        }
    }
}