using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V251.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V251.Group
{
///<summary>
///Represents the BRT_O32_ORDER Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: ORC (Common Order) </li>
///<li>1: BRT_O32_TIMING (a Group object) </li>
///<li>2: BPO (Blood product order) optional </li>
///<li>3: BTX (Blood Product Transfusion/Disposition) optional repeating</li>
///</ol>
///</summary>
[Serializable]
public class BRT_O32_ORDER : AbstractGroup {

	///<summary> 
	/// Creates a new BRT_O32_ORDER Group.
	///</summary>
	public BRT_O32_ORDER(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORC), true, false);
	      this.add(typeof(BRT_O32_TIMING), true, false);
	      this.add(typeof(BPO), false, false);
	      this.add(typeof(BTX), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating BRT_O32_ORDER - this is probably a bug in the source code generator.", e);
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
	/// Returns BRT_O32_TIMING (a Group object) - creates it if necessary
	///</summary>
	public BRT_O32_TIMING TIMING { 
get{
	   BRT_O32_TIMING ret = null;
	   try {
	      ret = (BRT_O32_TIMING)this.GetStructure("TIMING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns BPO (Blood product order) - creates it if necessary
	///</summary>
	public BPO BPO { 
get{
	   BPO ret = null;
	   try {
	      ret = (BPO)this.GetStructure("BPO");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of BTX (Blood Product Transfusion/Disposition) - creates it if necessary
	///</summary>
	public BTX GetBTX() {
	   BTX ret = null;
	   try {
	      ret = (BTX)this.GetStructure("BTX");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of BTX
	/// * (Blood Product Transfusion/Disposition) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public BTX GetBTX(int rep) { 
	   return (BTX)this.GetStructure("BTX", rep);
	}

	/** 
	 * Returns the number of existing repetitions of BTX 
	 */ 
	public int BTXRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("BTX").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}
