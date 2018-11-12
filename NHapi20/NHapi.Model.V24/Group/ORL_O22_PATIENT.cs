using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
///<summary>
///Represents the ORL_O22_PATIENT Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: PID (Patient identification) </li>
///<li>1: ORL_O22_GENERAL_ORDER (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class ORL_O22_PATIENT : AbstractGroup {

	///<summary> 
	/// Creates a new ORL_O22_PATIENT Group.
	///</summary>
	public ORL_O22_PATIENT(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(PID), true, false);
	      this.add(typeof(ORL_O22_GENERAL_ORDER), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORL_O22_PATIENT - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns PID (Patient identification) - creates it if necessary
	///</summary>
	public PID PID { 
get{
	   PID ret = null;
	   try {
	      ret = (PID)this.GetStructure("PID");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of ORL_O22_GENERAL_ORDER (a Group object) - creates it if necessary
	///</summary>
	public ORL_O22_GENERAL_ORDER GetGENERAL_ORDER() {
	   ORL_O22_GENERAL_ORDER ret = null;
	   try {
	      ret = (ORL_O22_GENERAL_ORDER)this.GetStructure("GENERAL_ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of ORL_O22_GENERAL_ORDER
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public ORL_O22_GENERAL_ORDER GetGENERAL_ORDER(int rep) { 
	   return (ORL_O22_GENERAL_ORDER)this.GetStructure("GENERAL_ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORL_O22_GENERAL_ORDER 
	 */ 
	public int GENERAL_ORDERRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("GENERAL_ORDER").Length; 
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
