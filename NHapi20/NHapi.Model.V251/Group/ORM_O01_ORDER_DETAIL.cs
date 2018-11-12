using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V251.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V251.Group
{
///<summary>
///Represents the ORM_O01_ORDER_DETAIL Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: OBR (Observation Request) </li>
///<li>1: RQD (Requisition Detail) </li>
///<li>2: RQ1 (Requisition Detail-1) </li>
///<li>3: RXO (Pharmacy/Treatment Order) </li>
///<li>4: ODS (Dietary Orders, Supplements, and Preferences) </li>
///<li>5: ODT (Diet Tray Instructions) </li>
///<li>6: NTE (Notes and Comments) optional repeating</li>
///<li>7: CTD (Contact Data) optional </li>
///<li>8: DG1 (Diagnosis) optional repeating</li>
///<li>9: ORM_O01_OBSERVATION (a Group object) </li>
///</ol>
///</summary>
[Serializable]
public class ORM_O01_ORDER_DETAIL : AbstractGroup {

	///<summary> 
	/// Creates a new ORM_O01_ORDER_DETAIL Group.
	///</summary>
	public ORM_O01_ORDER_DETAIL(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(OBR), true, false);
	      this.add(typeof(RQD), true, false);
	      this.add(typeof(RQ1), true, false);
	      this.add(typeof(RXO), true, false);
	      this.add(typeof(ODS), true, false);
	      this.add(typeof(ODT), true, false);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(CTD), false, false);
	      this.add(typeof(DG1), false, true);
	      this.add(typeof(ORM_O01_OBSERVATION), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORM_O01_ORDER_DETAIL - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns OBR (Observation Request) - creates it if necessary
	///</summary>
	public OBR OBR { 
get{
	   OBR ret = null;
	   try {
	      ret = (OBR)this.GetStructure("OBR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns RQD (Requisition Detail) - creates it if necessary
	///</summary>
	public RQD RQD { 
get{
	   RQD ret = null;
	   try {
	      ret = (RQD)this.GetStructure("RQD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns RQ1 (Requisition Detail-1) - creates it if necessary
	///</summary>
	public RQ1 RQ1 { 
get{
	   RQ1 ret = null;
	   try {
	      ret = (RQ1)this.GetStructure("RQ1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns RXO (Pharmacy/Treatment Order) - creates it if necessary
	///</summary>
	public RXO RXO { 
get{
	   RXO ret = null;
	   try {
	      ret = (RXO)this.GetStructure("RXO");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns ODS (Dietary Orders, Supplements, and Preferences) - creates it if necessary
	///</summary>
	public ODS ODS { 
get{
	   ODS ret = null;
	   try {
	      ret = (ODS)this.GetStructure("ODS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns ODT (Diet Tray Instructions) - creates it if necessary
	///</summary>
	public ODT ODT { 
get{
	   ODT ret = null;
	   try {
	      ret = (ODT)this.GetStructure("ODT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of NTE (Notes and Comments) - creates it if necessary
	///</summary>
	public NTE GetNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NTE
	/// * (Notes and Comments) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NTE GetNTE(int rep) { 
	   return (NTE)this.GetStructure("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns CTD (Contact Data) - creates it if necessary
	///</summary>
	public CTD CTD { 
get{
	   CTD ret = null;
	   try {
	      ret = (CTD)this.GetStructure("CTD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of DG1 (Diagnosis) - creates it if necessary
	///</summary>
	public DG1 GetDG1() {
	   DG1 ret = null;
	   try {
	      ret = (DG1)this.GetStructure("DG1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of DG1
	/// * (Diagnosis) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public DG1 GetDG1(int rep) { 
	   return (DG1)this.GetStructure("DG1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DG1 
	 */ 
	public int DG1RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("DG1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns ORM_O01_OBSERVATION (a Group object) - creates it if necessary
	///</summary>
	public ORM_O01_OBSERVATION OBSERVATION { 
get{
	   ORM_O01_OBSERVATION ret = null;
	   try {
	      ret = (ORM_O01_OBSERVATION)this.GetStructure("OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
