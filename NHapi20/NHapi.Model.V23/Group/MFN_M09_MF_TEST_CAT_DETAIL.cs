using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
///<summary>
///Represents the MFN_M09_MF_TEST_CAT_DETAIL Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: OM3 (Categorical test/observation) </li>
///<li>1: OM4 (Observations that require specimens) optional repeating</li>
///</ol>
///</summary>
[Serializable]
public class MFN_M09_MF_TEST_CAT_DETAIL : AbstractGroup {

	///<summary> 
	/// Creates a new MFN_M09_MF_TEST_CAT_DETAIL Group.
	///</summary>
	public MFN_M09_MF_TEST_CAT_DETAIL(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(OM3), true, false);
	      this.add(typeof(OM4), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFN_M09_MF_TEST_CAT_DETAIL - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns OM3 (Categorical test/observation) - creates it if necessary
	///</summary>
	public OM3 OM3 { 
get{
	   OM3 ret = null;
	   try {
	      ret = (OM3)this.GetStructure("OM3");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of OM4 (Observations that require specimens) - creates it if necessary
	///</summary>
	public OM4 GetOM4() {
	   OM4 ret = null;
	   try {
	      ret = (OM4)this.GetStructure("OM4");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of OM4
	/// * (Observations that require specimens) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public OM4 GetOM4(int rep) { 
	   return (OM4)this.GetStructure("OM4", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OM4 
	 */ 
	public int OM4RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("OM4").Length; 
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
