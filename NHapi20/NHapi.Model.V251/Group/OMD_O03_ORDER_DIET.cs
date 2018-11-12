using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V251.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V251.Group
{
///<summary>
///Represents the OMD_O03_ORDER_DIET Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: ORC (Common Order) </li>
///<li>1: OMD_O03_TIMING_DIET (a Group object) </li>
///<li>2: OMD_O03_DIET (a Group object) optional </li>
///</ol>
///</summary>
[Serializable]
public class OMD_O03_ORDER_DIET : AbstractGroup {

	///<summary> 
	/// Creates a new OMD_O03_ORDER_DIET Group.
	///</summary>
	public OMD_O03_ORDER_DIET(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORC), true, false);
	      this.add(typeof(OMD_O03_TIMING_DIET), true, false);
	      this.add(typeof(OMD_O03_DIET), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating OMD_O03_ORDER_DIET - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns ORC (Common Order) - creates it if necessary
	///</summary>
	public ORC ORC { 
get{
	   ORC ret = null;
	   try {
	      ret = (ORC)this.GetStructure("ORC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns OMD_O03_TIMING_DIET (a Group object) - creates it if necessary
	///</summary>
	public OMD_O03_TIMING_DIET TIMING_DIET { 
get{
	   OMD_O03_TIMING_DIET ret = null;
	   try {
	      ret = (OMD_O03_TIMING_DIET)this.GetStructure("TIMING_DIET");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns OMD_O03_DIET (a Group object) - creates it if necessary
	///</summary>
	public OMD_O03_DIET DIET { 
get{
	   OMD_O03_DIET ret = null;
	   try {
	      ret = (OMD_O03_DIET)this.GetStructure("DIET");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
