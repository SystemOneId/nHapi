using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V24.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V24.Segment{

///<summary>
/// Represents an HL7 PID message segment. 
/// This segment has the following fields:<ol>
///<li>PID-1: Set ID - PID (SI)</li>
///<li>PID-2: Patient ID (CX)</li>
///<li>PID-3: Patient Identifier List (CX)</li>
///<li>PID-4: Alternate Patient ID - PID (CX)</li>
///<li>PID-5: Patient Name (XPN)</li>
///<li>PID-6: Mother's Maiden Name (XPN)</li>
///<li>PID-7: Date/Time Of Birth (TS)</li>
///<li>PID-8: Administrative Sex (IS)</li>
///<li>PID-9: Patient Alias (XPN)</li>
///<li>PID-10: Race (CE)</li>
///<li>PID-11: Patient Address (XAD)</li>
///<li>PID-12: County Code (IS)</li>
///<li>PID-13: Phone Number - Home (XTN)</li>
///<li>PID-14: Phone Number - Business (XTN)</li>
///<li>PID-15: Primary Language (CE)</li>
///<li>PID-16: Marital Status (CE)</li>
///<li>PID-17: Religion (CE)</li>
///<li>PID-18: Patient Account Number (CX)</li>
///<li>PID-19: SSN Number - Patient (ST)</li>
///<li>PID-20: Driver's License Number - Patient (DLN)</li>
///<li>PID-21: Mother's Identifier (CX)</li>
///<li>PID-22: Ethnic Group (CE)</li>
///<li>PID-23: Birth Place (ST)</li>
///<li>PID-24: Multiple Birth Indicator (ID)</li>
///<li>PID-25: Birth Order (NM)</li>
///<li>PID-26: Citizenship (CE)</li>
///<li>PID-27: Veterans Military Status (CE)</li>
///<li>PID-28: Nationality (CE)</li>
///<li>PID-29: Patient Death Date and Time (TS)</li>
///<li>PID-30: Patient Death Indicator (ID)</li>
///<li>PID-31: Identity Unknown Indicator (ID)</li>
///<li>PID-32: Identity Reliability Code (IS)</li>
///<li>PID-33: Last Update Date/Time (TS)</li>
///<li>PID-34: Last Update Facility (HD)</li>
///<li>PID-35: Species Code (CE)</li>
///<li>PID-36: Breed Code (CE)</li>
///<li>PID-37: Strain (ST)</li>
///<li>PID-38: Production Class Code (CE)</li>
///</ol>
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class PID : AbstractSegment  {

  /**
   * Creates a PID (Patient identification) segment object that belongs to the given 
   * message.  
   */
	public PID(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "Set ID - PID");
       this.add(typeof(CX), false, 1, 20, new System.Object[]{message}, "Patient ID");
       this.add(typeof(CX), true, 0, 250, new System.Object[]{message}, "Patient Identifier List");
       this.add(typeof(CX), false, 0, 20, new System.Object[]{message}, "Alternate Patient ID - PID");
       this.add(typeof(XPN), true, 0, 250, new System.Object[]{message}, "Patient Name");
       this.add(typeof(XPN), false, 0, 250, new System.Object[]{message}, "Mother's Maiden Name");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Date/Time Of Birth");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 1}, "Administrative Sex");
       this.add(typeof(XPN), false, 0, 250, new System.Object[]{message}, "Patient Alias");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Race");
       this.add(typeof(XAD), false, 0, 250, new System.Object[]{message}, "Patient Address");
       this.add(typeof(IS), false, 1, 4, new System.Object[]{message, 289}, "County Code");
       this.add(typeof(XTN), false, 0, 250, new System.Object[]{message}, "Phone Number - Home");
       this.add(typeof(XTN), false, 0, 250, new System.Object[]{message}, "Phone Number - Business");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Primary Language");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Marital Status");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Religion");
       this.add(typeof(CX), false, 1, 250, new System.Object[]{message}, "Patient Account Number");
       this.add(typeof(ST), false, 1, 16, new System.Object[]{message}, "SSN Number - Patient");
       this.add(typeof(DLN), false, 1, 25, new System.Object[]{message}, "Driver's License Number - Patient");
       this.add(typeof(CX), false, 0, 250, new System.Object[]{message}, "Mother's Identifier");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Ethnic Group");
       this.add(typeof(ST), false, 1, 250, new System.Object[]{message}, "Birth Place");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Multiple Birth Indicator");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Birth Order");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Citizenship");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Veterans Military Status");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Nationality");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Patient Death Date and Time");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Patient Death Indicator");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Identity Unknown Indicator");
       this.add(typeof(IS), false, 0, 20, new System.Object[]{message, 445}, "Identity Reliability Code");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Last Update Date/Time");
       this.add(typeof(HD), false, 1, 40, new System.Object[]{message}, "Last Update Facility");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Species Code");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Breed Code");
       this.add(typeof(ST), false, 1, 80, new System.Object[]{message}, "Strain");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Production Class Code");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Set ID - PID(PID-1).
	///</summary>
	public SI SetIDPID
	{
		get{
			SI ret = null;
			try
			{
			IType t = this.GetField(1, 0);
				ret = (SI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Patient ID(PID-2).
	///</summary>
	public CX PatientID
	{
		get{
			CX ret = null;
			try
			{
			IType t = this.GetField(2, 0);
				ret = (CX)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns a single repetition of Patient Identifier List(PID-3).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CX GetPatientIdentifierList(int rep)
	{
			CX ret = null;
			try
			{
			IType t = this.GetField(3, rep);
				ret = (CX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Patient Identifier List (PID-3).
   ///</summary>
  public CX[] GetPatientIdentifierList() {
     CX[] ret = null;
    try {
        IType[] t = this.GetField(3);  
        ret = new CX[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CX)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  ///<summary>
  /// Returns the total repetitions of Patient Identifier List (PID-3).
   ///</summary>
  public int PatientIdentifierListRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(3);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns a single repetition of Alternate Patient ID - PID(PID-4).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CX GetAlternatePatientIDPID(int rep)
	{
			CX ret = null;
			try
			{
			IType t = this.GetField(4, rep);
				ret = (CX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Alternate Patient ID - PID (PID-4).
   ///</summary>
  public CX[] GetAlternatePatientIDPID() {
     CX[] ret = null;
    try {
        IType[] t = this.GetField(4);  
        ret = new CX[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CX)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  ///<summary>
  /// Returns the total repetitions of Alternate Patient ID - PID (PID-4).
   ///</summary>
  public int AlternatePatientIDPIDRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(4);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns a single repetition of Patient Name(PID-5).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XPN GetPatientName(int rep)
	{
			XPN ret = null;
			try
			{
			IType t = this.GetField(5, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Patient Name (PID-5).
   ///</summary>
  public XPN[] GetPatientName() {
     XPN[] ret = null;
    try {
        IType[] t = this.GetField(5);  
        ret = new XPN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XPN)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  ///<summary>
  /// Returns the total repetitions of Patient Name (PID-5).
   ///</summary>
  public int PatientNameRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(5);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns a single repetition of Mother's Maiden Name(PID-6).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XPN GetMotherSMaidenName(int rep)
	{
			XPN ret = null;
			try
			{
			IType t = this.GetField(6, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Mother's Maiden Name (PID-6).
   ///</summary>
  public XPN[] GetMotherSMaidenName() {
     XPN[] ret = null;
    try {
        IType[] t = this.GetField(6);  
        ret = new XPN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XPN)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  ///<summary>
  /// Returns the total repetitions of Mother's Maiden Name (PID-6).
   ///</summary>
  public int MotherSMaidenNameRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(6);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns Date/Time Of Birth(PID-7).
	///</summary>
	public TS DateTimeOfBirth
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(7, 0);
				ret = (TS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Administrative Sex(PID-8).
	///</summary>
	public IS AdministrativeSex
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(8, 0);
				ret = (IS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns a single repetition of Patient Alias(PID-9).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XPN GetPatientAlias(int rep)
	{
			XPN ret = null;
			try
			{
			IType t = this.GetField(9, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Patient Alias (PID-9).
   ///</summary>
  public XPN[] GetPatientAlias() {
     XPN[] ret = null;
    try {
        IType[] t = this.GetField(9);  
        ret = new XPN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XPN)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  ///<summary>
  /// Returns the total repetitions of Patient Alias (PID-9).
   ///</summary>
  public int PatientAliasRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(9);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns a single repetition of Race(PID-10).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CE GetRace(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(10, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Race (PID-10).
   ///</summary>
  public CE[] GetRace() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(10);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  ///<summary>
  /// Returns the total repetitions of Race (PID-10).
   ///</summary>
  public int RaceRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(10);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns a single repetition of Patient Address(PID-11).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XAD GetPatientAddress(int rep)
	{
			XAD ret = null;
			try
			{
			IType t = this.GetField(11, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Patient Address (PID-11).
   ///</summary>
  public XAD[] GetPatientAddress() {
     XAD[] ret = null;
    try {
        IType[] t = this.GetField(11);  
        ret = new XAD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XAD)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  ///<summary>
  /// Returns the total repetitions of Patient Address (PID-11).
   ///</summary>
  public int PatientAddressRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(11);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns County Code(PID-12).
	///</summary>
	public IS CountyCode
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(12, 0);
				ret = (IS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns a single repetition of Phone Number - Home(PID-13).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XTN GetPhoneNumberHome(int rep)
	{
			XTN ret = null;
			try
			{
			IType t = this.GetField(13, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Phone Number - Home (PID-13).
   ///</summary>
  public XTN[] GetPhoneNumberHome() {
     XTN[] ret = null;
    try {
        IType[] t = this.GetField(13);  
        ret = new XTN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XTN)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  ///<summary>
  /// Returns the total repetitions of Phone Number - Home (PID-13).
   ///</summary>
  public int PhoneNumberHomeRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(13);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns a single repetition of Phone Number - Business(PID-14).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XTN GetPhoneNumberBusiness(int rep)
	{
			XTN ret = null;
			try
			{
			IType t = this.GetField(14, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Phone Number - Business (PID-14).
   ///</summary>
  public XTN[] GetPhoneNumberBusiness() {
     XTN[] ret = null;
    try {
        IType[] t = this.GetField(14);  
        ret = new XTN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XTN)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  ///<summary>
  /// Returns the total repetitions of Phone Number - Business (PID-14).
   ///</summary>
  public int PhoneNumberBusinessRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(14);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns Primary Language(PID-15).
	///</summary>
	public CE PrimaryLanguage
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(15, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Marital Status(PID-16).
	///</summary>
	public CE MaritalStatus
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(16, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Religion(PID-17).
	///</summary>
	public CE Religion
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(17, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Patient Account Number(PID-18).
	///</summary>
	public CX PatientAccountNumber
	{
		get{
			CX ret = null;
			try
			{
			IType t = this.GetField(18, 0);
				ret = (CX)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns SSN Number - Patient(PID-19).
	///</summary>
	public ST SSNNumberPatient
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(19, 0);
				ret = (ST)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Driver's License Number - Patient(PID-20).
	///</summary>
	public DLN DriverSLicenseNumberPatient
	{
		get{
			DLN ret = null;
			try
			{
			IType t = this.GetField(20, 0);
				ret = (DLN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns a single repetition of Mother's Identifier(PID-21).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CX GetMotherSIdentifier(int rep)
	{
			CX ret = null;
			try
			{
			IType t = this.GetField(21, rep);
				ret = (CX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Mother's Identifier (PID-21).
   ///</summary>
  public CX[] GetMotherSIdentifier() {
     CX[] ret = null;
    try {
        IType[] t = this.GetField(21);  
        ret = new CX[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CX)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  ///<summary>
  /// Returns the total repetitions of Mother's Identifier (PID-21).
   ///</summary>
  public int MotherSIdentifierRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(21);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns a single repetition of Ethnic Group(PID-22).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CE GetEthnicGroup(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(22, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Ethnic Group (PID-22).
   ///</summary>
  public CE[] GetEthnicGroup() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(22);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  ///<summary>
  /// Returns the total repetitions of Ethnic Group (PID-22).
   ///</summary>
  public int EthnicGroupRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(22);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns Birth Place(PID-23).
	///</summary>
	public ST BirthPlace
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(23, 0);
				ret = (ST)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Multiple Birth Indicator(PID-24).
	///</summary>
	public ID MultipleBirthIndicator
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(24, 0);
				ret = (ID)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Birth Order(PID-25).
	///</summary>
	public NM BirthOrder
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(25, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns a single repetition of Citizenship(PID-26).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CE GetCitizenship(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(26, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Citizenship (PID-26).
   ///</summary>
  public CE[] GetCitizenship() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(26);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  ///<summary>
  /// Returns the total repetitions of Citizenship (PID-26).
   ///</summary>
  public int CitizenshipRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(26);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns Veterans Military Status(PID-27).
	///</summary>
	public CE VeteransMilitaryStatus
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(27, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Nationality(PID-28).
	///</summary>
	public CE Nationality
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(28, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Patient Death Date and Time(PID-29).
	///</summary>
	public TS PatientDeathDateAndTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(29, 0);
				ret = (TS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Patient Death Indicator(PID-30).
	///</summary>
	public ID PatientDeathIndicator
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(30, 0);
				ret = (ID)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Identity Unknown Indicator(PID-31).
	///</summary>
	public ID IdentityUnknownIndicator
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(31, 0);
				ret = (ID)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns a single repetition of Identity Reliability Code(PID-32).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public IS GetIdentityReliabilityCode(int rep)
	{
			IS ret = null;
			try
			{
			IType t = this.GetField(32, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Identity Reliability Code (PID-32).
   ///</summary>
  public IS[] GetIdentityReliabilityCode() {
     IS[] ret = null;
    try {
        IType[] t = this.GetField(32);  
        ret = new IS[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (IS)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  ///<summary>
  /// Returns the total repetitions of Identity Reliability Code (PID-32).
   ///</summary>
  public int IdentityReliabilityCodeRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(32);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns Last Update Date/Time(PID-33).
	///</summary>
	public TS LastUpdateDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(33, 0);
				ret = (TS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Last Update Facility(PID-34).
	///</summary>
	public HD LastUpdateFacility
	{
		get{
			HD ret = null;
			try
			{
			IType t = this.GetField(34, 0);
				ret = (HD)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Species Code(PID-35).
	///</summary>
	public CE SpeciesCode
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(35, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Breed Code(PID-36).
	///</summary>
	public CE BreedCode
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(36, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Strain(PID-37).
	///</summary>
	public ST Strain
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(37, 0);
				ret = (ST)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Production Class Code(PID-38).
	///</summary>
	public CE ProductionClassCode
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(38, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }


}}