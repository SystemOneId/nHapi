using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
///<summary>
///Represents the DFT_P03_FINANCIAL Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: FT1 (FT1 - financial transaction segment) </li>
///<li>1: DFT_P03_FINANCIAL_PROCEDURE (a Group object) optional repeating</li>
///</ol>
///</summary>
[Serializable]
public class DFT_P03_FINANCIAL : AbstractGroup {

	///<summary> 
	/// Creates a new DFT_P03_FINANCIAL Group.
	///</summary>
	public DFT_P03_FINANCIAL(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(FT1), true, false);
	      this.add(typeof(DFT_P03_FINANCIAL_PROCEDURE), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating DFT_P03_FINANCIAL - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns FT1 (FT1 - financial transaction segment) - creates it if necessary
	///</summary>
	public FT1 FT1 { 
get{
	   FT1 ret = null;
	   try {
	      ret = (FT1)this.GetStructure("FT1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of DFT_P03_FINANCIAL_PROCEDURE (a Group object) - creates it if necessary
	///</summary>
	public DFT_P03_FINANCIAL_PROCEDURE GetFINANCIAL_PROCEDURE() {
	   DFT_P03_FINANCIAL_PROCEDURE ret = null;
	   try {
	      ret = (DFT_P03_FINANCIAL_PROCEDURE)this.GetStructure("FINANCIAL_PROCEDURE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of DFT_P03_FINANCIAL_PROCEDURE
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public DFT_P03_FINANCIAL_PROCEDURE GetFINANCIAL_PROCEDURE(int rep) { 
	   return (DFT_P03_FINANCIAL_PROCEDURE)this.GetStructure("FINANCIAL_PROCEDURE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DFT_P03_FINANCIAL_PROCEDURE 
	 */ 
	public int FINANCIAL_PROCEDURERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("FINANCIAL_PROCEDURE").Length; 
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
