using System;
using NHapi.Base.Log;
using NHapi.Model.V251.Group;
using NHapi.Model.V251.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V251.Message

{
///<summary>
/// Represents a SIU_S12 message structure (see chapter 10.4). This structure contains the 
/// following elements:
///<ol>
///<li>0: MSH (Message Header) </li>
///<li>1: SCH (Scheduling Activity Information) </li>
///<li>2: TQ1 (Timing/Quantity) optional repeating</li>
///<li>3: NTE (Notes and Comments) optional repeating</li>
///<li>4: SIU_S12_PATIENT (a Group object) </li>
///<li>5: SIU_S12_RESOURCES (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class SIU_S12 : AbstractMessage  {

	///<summary> 
	/// Creates a new SIU_S12 Group with custom IModelClassFactory.
	///</summary>
	public SIU_S12(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new SIU_S12 Group with DefaultModelClassFactory. 
	///</summary> 
	public SIU_S12() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for SIU_S12.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(SCH), true, false);
	      this.add(typeof(TQ1), false, true);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(SIU_S12_PATIENT), true, false);
	      this.add(typeof(SIU_S12_RESOURCES), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating SIU_S12 - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns MSH (Message Header) - creates it if necessary
	///</summary>
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.GetStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns SCH (Scheduling Activity Information) - creates it if necessary
	///</summary>
	public SCH SCH { 
get{
	   SCH ret = null;
	   try {
	      ret = (SCH)this.GetStructure("SCH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of TQ1 (Timing/Quantity) - creates it if necessary
	///</summary>
	public TQ1 GetTQ1() {
	   TQ1 ret = null;
	   try {
	      ret = (TQ1)this.GetStructure("TQ1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of TQ1
	/// * (Timing/Quantity) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public TQ1 GetTQ1(int rep) { 
	   return (TQ1)this.GetStructure("TQ1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of TQ1 
	 */ 
	public int TQ1RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("TQ1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
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
	/// Returns SIU_S12_PATIENT (a Group object) - creates it if necessary
	///</summary>
	public SIU_S12_PATIENT PATIENT { 
get{
	   SIU_S12_PATIENT ret = null;
	   try {
	      ret = (SIU_S12_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of SIU_S12_RESOURCES (a Group object) - creates it if necessary
	///</summary>
	public SIU_S12_RESOURCES GetRESOURCES() {
	   SIU_S12_RESOURCES ret = null;
	   try {
	      ret = (SIU_S12_RESOURCES)this.GetStructure("RESOURCES");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of SIU_S12_RESOURCES
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public SIU_S12_RESOURCES GetRESOURCES(int rep) { 
	   return (SIU_S12_RESOURCES)this.GetStructure("RESOURCES", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SIU_S12_RESOURCES 
	 */ 
	public int RESOURCESRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("RESOURCES").Length; 
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
