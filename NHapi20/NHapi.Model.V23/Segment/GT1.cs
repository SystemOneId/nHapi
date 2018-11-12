using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment{

///<summary>
/// Represents an HL7 GT1 message segment. 
/// This segment has the following fields:<ol>
///<li>GT1-1: Set ID - Guarantor (SI)</li>
///<li>GT1-2: Guarantor Number (CX)</li>
///<li>GT1-3: Guarantor Name (XPN)</li>
///<li>GT1-4: Guarantor Spouse Name (XPN)</li>
///<li>GT1-5: Guarantor Address (XAD)</li>
///<li>GT1-6: Guarantor Ph Num- Home (XTN)</li>
///<li>GT1-7: Guarantor Ph Num-Business (XTN)</li>
///<li>GT1-8: Guarantor Date/Time of Birth (TS)</li>
///<li>GT1-9: Guarantor Sex (IS)</li>
///<li>GT1-10: Guarantor Type (IS)</li>
///<li>GT1-11: Guarantor Relationship (IS)</li>
///<li>GT1-12: Guarantor SSN (ST)</li>
///<li>GT1-13: Guarantor Date - Begin (DT)</li>
///<li>GT1-14: Guarantor Date - End (DT)</li>
///<li>GT1-15: Guarantor Priority (NM)</li>
///<li>GT1-16: Guarantor Employer Name (XPN)</li>
///<li>GT1-17: Guarantor Employer Address (XAD)</li>
///<li>GT1-18: Guarantor Employ Phone Number (XTN)</li>
///<li>GT1-19: Guarantor Employee ID Number (CX)</li>
///<li>GT1-20: Guarantor Employment Status (IS)</li>
///<li>GT1-21: Guarantor Organization (XON)</li>
///<li>GT1-22: Guarantor Billing Hold Flag (ID)</li>
///<li>GT1-23: Guarantor Credit Rating Code (CE)</li>
///<li>GT1-24: Guarantor Death Date And Time (TS)</li>
///<li>GT1-25: Guarantor Death Flag (ID)</li>
///<li>GT1-26: Guarantor Charge Adjustment Code (CE)</li>
///<li>GT1-27: Guarantor Household Annual Income (CP)</li>
///<li>GT1-28: Guarantor Household Size (NM)</li>
///<li>GT1-29: Guarantor Employer ID Number (CX)</li>
///<li>GT1-30: Guarantor Marital Status Code (IS)</li>
///<li>GT1-31: Guarantor Hire Effective Date (DT)</li>
///<li>GT1-32: Employment Stop Date (DT)</li>
///<li>GT1-33: Living Dependency (IS)</li>
///<li>GT1-34: Ambulatory Status (IS)</li>
///<li>GT1-35: Citizenship (IS)</li>
///<li>GT1-36: Primary Language (CE)</li>
///<li>GT1-37: Living Arrangement (IS)</li>
///<li>GT1-38: Publicity Indicator (CE)</li>
///<li>GT1-39: Protection Indicator (ID)</li>
///<li>GT1-40: Student Indicator (IS)</li>
///<li>GT1-41: Religion (IS)</li>
///<li>GT1-42: Mother’s Maiden Name (XPN)</li>
///<li>GT1-43: Nationality Code (CE)</li>
///<li>GT1-44: Ethnic Group (IS)</li>
///<li>GT1-45: Contact Person's Name (XPN)</li>
///<li>GT1-46: Contact Person’s Telephone Number (XTN)</li>
///<li>GT1-47: Contact Reason (CE)</li>
///<li>GT1-48: Contact Relationship Code (IS)</li>
///<li>GT1-49: Job Title (ST)</li>
///<li>GT1-50: Job Code/Class (JCC)</li>
///<li>GT1-51: Guarantor Employer's Organization Name (XON)</li>
///<li>GT1-52: Handicap (IS)</li>
///<li>GT1-53: Job Status (IS)</li>
///<li>GT1-54: Guarantor Financial Class (FC)</li>
///<li>GT1-55: Guarantor Race (IS)</li>
///</ol>
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class GT1 : AbstractSegment  {

  /**
   * Creates a GT1 (Guarantor) segment object that belongs to the given 
   * message.  
   */
	public GT1(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message}, "Set ID - Guarantor");
       this.add(typeof(CX), false, 0, 59, new System.Object[]{message}, "Guarantor Number");
       this.add(typeof(XPN), true, 0, 48, new System.Object[]{message}, "Guarantor Name");
       this.add(typeof(XPN), false, 0, 48, new System.Object[]{message}, "Guarantor Spouse Name");
       this.add(typeof(XAD), false, 0, 106, new System.Object[]{message}, "Guarantor Address");
       this.add(typeof(XTN), false, 0, 40, new System.Object[]{message}, "Guarantor Ph Num- Home");
       this.add(typeof(XTN), false, 0, 40, new System.Object[]{message}, "Guarantor Ph Num-Business");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Guarantor Date/Time of Birth");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 1}, "Guarantor Sex");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 68}, "Guarantor Type");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 63}, "Guarantor Relationship");
       this.add(typeof(ST), false, 1, 11, new System.Object[]{message}, "Guarantor SSN");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Guarantor Date - Begin");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Guarantor Date - End");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Guarantor Priority");
       this.add(typeof(XPN), false, 0, 130, new System.Object[]{message}, "Guarantor Employer Name");
       this.add(typeof(XAD), false, 0, 106, new System.Object[]{message}, "Guarantor Employer Address");
       this.add(typeof(XTN), false, 0, 40, new System.Object[]{message}, "Guarantor Employ Phone Number");
       this.add(typeof(CX), false, 0, 20, new System.Object[]{message}, "Guarantor Employee ID Number");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 66}, "Guarantor Employment Status");
       this.add(typeof(XON), false, 0, 130, new System.Object[]{message}, "Guarantor Organization");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Guarantor Billing Hold Flag");
       this.add(typeof(CE), false, 1, 80, new System.Object[]{message}, "Guarantor Credit Rating Code");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Guarantor Death Date And Time");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Guarantor Death Flag");
       this.add(typeof(CE), false, 1, 80, new System.Object[]{message}, "Guarantor Charge Adjustment Code");
       this.add(typeof(CP), false, 1, 10, new System.Object[]{message}, "Guarantor Household Annual Income");
       this.add(typeof(NM), false, 1, 3, new System.Object[]{message}, "Guarantor Household Size");
       this.add(typeof(CX), false, 0, 20, new System.Object[]{message}, "Guarantor Employer ID Number");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 0}, "Guarantor Marital Status Code");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Guarantor Hire Effective Date");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Employment Stop Date");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 223}, "Living Dependency");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 9}, "Ambulatory Status");
       this.add(typeof(IS), false, 1, 4, new System.Object[]{message, 171}, "Citizenship");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Primary Language");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 220}, "Living Arrangement");
       this.add(typeof(CE), false, 1, 1, new System.Object[]{message}, "Publicity Indicator");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Protection Indicator");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 231}, "Student Indicator");
       this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 6}, "Religion");
       this.add(typeof(XPN), false, 1, 48, new System.Object[]{message}, "Mother’s Maiden Name");
       this.add(typeof(CE), false, 1, 80, new System.Object[]{message}, "Nationality Code");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 189}, "Ethnic Group");
       this.add(typeof(XPN), false, 0, 48, new System.Object[]{message}, "Contact Person's Name");
       this.add(typeof(XTN), false, 0, 40, new System.Object[]{message}, "Contact Person’s Telephone Number");
       this.add(typeof(CE), false, 1, 2, new System.Object[]{message}, "Contact Reason");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 63}, "Contact Relationship Code");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "Job Title");
       this.add(typeof(JCC), false, 1, 20, new System.Object[]{message}, "Job Code/Class");
       this.add(typeof(XON), false, 0, 130, new System.Object[]{message}, "Guarantor Employer's Organization Name");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 310}, "Handicap");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 311}, "Job Status");
       this.add(typeof(FC), false, 1, 50, new System.Object[]{message}, "Guarantor Financial Class");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 5}, "Guarantor Race");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Set ID - Guarantor(GT1-1).
	///</summary>
	public SI SetIDGuarantor
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
	/// Returns a single repetition of Guarantor Number(GT1-2).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CX GetGuarantorNumber(int rep)
	{
			CX ret = null;
			try
			{
			IType t = this.GetField(2, rep);
				ret = (CX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Guarantor Number (GT1-2).
   ///</summary>
  public CX[] GetGuarantorNumber() {
     CX[] ret = null;
    try {
        IType[] t = this.GetField(2);  
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
  /// Returns the total repetitions of Guarantor Number (GT1-2).
   ///</summary>
  public int GuarantorNumberRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(2);
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
	/// Returns a single repetition of Guarantor Name(GT1-3).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XPN GetGuarantorName(int rep)
	{
			XPN ret = null;
			try
			{
			IType t = this.GetField(3, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Guarantor Name (GT1-3).
   ///</summary>
  public XPN[] GetGuarantorName() {
     XPN[] ret = null;
    try {
        IType[] t = this.GetField(3);  
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
  /// Returns the total repetitions of Guarantor Name (GT1-3).
   ///</summary>
  public int GuarantorNameRepetitionsUsed
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
	/// Returns a single repetition of Guarantor Spouse Name(GT1-4).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XPN GetGuarantorSpouseName(int rep)
	{
			XPN ret = null;
			try
			{
			IType t = this.GetField(4, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Guarantor Spouse Name (GT1-4).
   ///</summary>
  public XPN[] GetGuarantorSpouseName() {
     XPN[] ret = null;
    try {
        IType[] t = this.GetField(4);  
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
  /// Returns the total repetitions of Guarantor Spouse Name (GT1-4).
   ///</summary>
  public int GuarantorSpouseNameRepetitionsUsed
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
	/// Returns a single repetition of Guarantor Address(GT1-5).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XAD GetGuarantorAddress(int rep)
	{
			XAD ret = null;
			try
			{
			IType t = this.GetField(5, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Guarantor Address (GT1-5).
   ///</summary>
  public XAD[] GetGuarantorAddress() {
     XAD[] ret = null;
    try {
        IType[] t = this.GetField(5);  
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
  /// Returns the total repetitions of Guarantor Address (GT1-5).
   ///</summary>
  public int GuarantorAddressRepetitionsUsed
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
	/// Returns a single repetition of Guarantor Ph Num- Home(GT1-6).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XTN GetGuarantorPhNumHome(int rep)
	{
			XTN ret = null;
			try
			{
			IType t = this.GetField(6, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Guarantor Ph Num- Home (GT1-6).
   ///</summary>
  public XTN[] GetGuarantorPhNumHome() {
     XTN[] ret = null;
    try {
        IType[] t = this.GetField(6);  
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
  /// Returns the total repetitions of Guarantor Ph Num- Home (GT1-6).
   ///</summary>
  public int GuarantorPhNumHomeRepetitionsUsed
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
	/// Returns a single repetition of Guarantor Ph Num-Business(GT1-7).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XTN GetGuarantorPhNumBusiness(int rep)
	{
			XTN ret = null;
			try
			{
			IType t = this.GetField(7, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Guarantor Ph Num-Business (GT1-7).
   ///</summary>
  public XTN[] GetGuarantorPhNumBusiness() {
     XTN[] ret = null;
    try {
        IType[] t = this.GetField(7);  
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
  /// Returns the total repetitions of Guarantor Ph Num-Business (GT1-7).
   ///</summary>
  public int GuarantorPhNumBusinessRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(7);
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
	/// Returns Guarantor Date/Time of Birth(GT1-8).
	///</summary>
	public TS GuarantorDateTimeOfBirth
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(8, 0);
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
	/// Returns Guarantor Sex(GT1-9).
	///</summary>
	public IS GuarantorSex
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(9, 0);
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
	/// Returns Guarantor Type(GT1-10).
	///</summary>
	public IS GuarantorType
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(10, 0);
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
	/// Returns Guarantor Relationship(GT1-11).
	///</summary>
	public IS GuarantorRelationship
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(11, 0);
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
	/// Returns Guarantor SSN(GT1-12).
	///</summary>
	public ST GuarantorSSN
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(12, 0);
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
	/// Returns Guarantor Date - Begin(GT1-13).
	///</summary>
	public DT GuarantorDateBegin
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(13, 0);
				ret = (DT)t;
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
	/// Returns Guarantor Date - End(GT1-14).
	///</summary>
	public DT GuarantorDateEnd
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(14, 0);
				ret = (DT)t;
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
	/// Returns Guarantor Priority(GT1-15).
	///</summary>
	public NM GuarantorPriority
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(15, 0);
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
	/// Returns a single repetition of Guarantor Employer Name(GT1-16).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XPN GetGuarantorEmployerName(int rep)
	{
			XPN ret = null;
			try
			{
			IType t = this.GetField(16, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Guarantor Employer Name (GT1-16).
   ///</summary>
  public XPN[] GetGuarantorEmployerName() {
     XPN[] ret = null;
    try {
        IType[] t = this.GetField(16);  
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
  /// Returns the total repetitions of Guarantor Employer Name (GT1-16).
   ///</summary>
  public int GuarantorEmployerNameRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(16);
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
	/// Returns a single repetition of Guarantor Employer Address(GT1-17).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XAD GetGuarantorEmployerAddress(int rep)
	{
			XAD ret = null;
			try
			{
			IType t = this.GetField(17, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Guarantor Employer Address (GT1-17).
   ///</summary>
  public XAD[] GetGuarantorEmployerAddress() {
     XAD[] ret = null;
    try {
        IType[] t = this.GetField(17);  
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
  /// Returns the total repetitions of Guarantor Employer Address (GT1-17).
   ///</summary>
  public int GuarantorEmployerAddressRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(17);
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
	/// Returns a single repetition of Guarantor Employ Phone Number(GT1-18).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XTN GetGuarantorEmployPhoneNumber(int rep)
	{
			XTN ret = null;
			try
			{
			IType t = this.GetField(18, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Guarantor Employ Phone Number (GT1-18).
   ///</summary>
  public XTN[] GetGuarantorEmployPhoneNumber() {
     XTN[] ret = null;
    try {
        IType[] t = this.GetField(18);  
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
  /// Returns the total repetitions of Guarantor Employ Phone Number (GT1-18).
   ///</summary>
  public int GuarantorEmployPhoneNumberRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(18);
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
	/// Returns a single repetition of Guarantor Employee ID Number(GT1-19).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CX GetGuarantorEmployeeIDNumber(int rep)
	{
			CX ret = null;
			try
			{
			IType t = this.GetField(19, rep);
				ret = (CX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Guarantor Employee ID Number (GT1-19).
   ///</summary>
  public CX[] GetGuarantorEmployeeIDNumber() {
     CX[] ret = null;
    try {
        IType[] t = this.GetField(19);  
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
  /// Returns the total repetitions of Guarantor Employee ID Number (GT1-19).
   ///</summary>
  public int GuarantorEmployeeIDNumberRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(19);
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
	/// Returns Guarantor Employment Status(GT1-20).
	///</summary>
	public IS GuarantorEmploymentStatus
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(20, 0);
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
	/// Returns a single repetition of Guarantor Organization(GT1-21).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XON GetGuarantorOrganization(int rep)
	{
			XON ret = null;
			try
			{
			IType t = this.GetField(21, rep);
				ret = (XON)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Guarantor Organization (GT1-21).
   ///</summary>
  public XON[] GetGuarantorOrganization() {
     XON[] ret = null;
    try {
        IType[] t = this.GetField(21);  
        ret = new XON[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XON)t[i];
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
  /// Returns the total repetitions of Guarantor Organization (GT1-21).
   ///</summary>
  public int GuarantorOrganizationRepetitionsUsed
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
	/// Returns Guarantor Billing Hold Flag(GT1-22).
	///</summary>
	public ID GuarantorBillingHoldFlag
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(22, 0);
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
	/// Returns Guarantor Credit Rating Code(GT1-23).
	///</summary>
	public CE GuarantorCreditRatingCode
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(23, 0);
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
	/// Returns Guarantor Death Date And Time(GT1-24).
	///</summary>
	public TS GuarantorDeathDateAndTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(24, 0);
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
	/// Returns Guarantor Death Flag(GT1-25).
	///</summary>
	public ID GuarantorDeathFlag
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(25, 0);
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
	/// Returns Guarantor Charge Adjustment Code(GT1-26).
	///</summary>
	public CE GuarantorChargeAdjustmentCode
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(26, 0);
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
	/// Returns Guarantor Household Annual Income(GT1-27).
	///</summary>
	public CP GuarantorHouseholdAnnualIncome
	{
		get{
			CP ret = null;
			try
			{
			IType t = this.GetField(27, 0);
				ret = (CP)t;
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
	/// Returns Guarantor Household Size(GT1-28).
	///</summary>
	public NM GuarantorHouseholdSize
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(28, 0);
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
	/// Returns a single repetition of Guarantor Employer ID Number(GT1-29).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CX GetGuarantorEmployerIDNumber(int rep)
	{
			CX ret = null;
			try
			{
			IType t = this.GetField(29, rep);
				ret = (CX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Guarantor Employer ID Number (GT1-29).
   ///</summary>
  public CX[] GetGuarantorEmployerIDNumber() {
     CX[] ret = null;
    try {
        IType[] t = this.GetField(29);  
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
  /// Returns the total repetitions of Guarantor Employer ID Number (GT1-29).
   ///</summary>
  public int GuarantorEmployerIDNumberRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(29);
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
	/// Returns Guarantor Marital Status Code(GT1-30).
	///</summary>
	public IS GuarantorMaritalStatusCode
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(30, 0);
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
	/// Returns Guarantor Hire Effective Date(GT1-31).
	///</summary>
	public DT GuarantorHireEffectiveDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(31, 0);
				ret = (DT)t;
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
	/// Returns Employment Stop Date(GT1-32).
	///</summary>
	public DT EmploymentStopDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(32, 0);
				ret = (DT)t;
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
	/// Returns Living Dependency(GT1-33).
	///</summary>
	public IS LivingDependency
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(33, 0);
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
	/// Returns Ambulatory Status(GT1-34).
	///</summary>
	public IS AmbulatoryStatus
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(34, 0);
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
	/// Returns Citizenship(GT1-35).
	///</summary>
	public IS Citizenship
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(35, 0);
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
	/// Returns Primary Language(GT1-36).
	///</summary>
	public CE PrimaryLanguage
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
	/// Returns Living Arrangement(GT1-37).
	///</summary>
	public IS LivingArrangement
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(37, 0);
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
	/// Returns Publicity Indicator(GT1-38).
	///</summary>
	public CE PublicityIndicator
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

	///<summary>
	/// Returns Protection Indicator(GT1-39).
	///</summary>
	public ID ProtectionIndicator
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(39, 0);
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
	/// Returns Student Indicator(GT1-40).
	///</summary>
	public IS StudentIndicator
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(40, 0);
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
	/// Returns Religion(GT1-41).
	///</summary>
	public IS Religion
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(41, 0);
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
	/// Returns Mother’s Maiden Name(GT1-42).
	///</summary>
	public XPN MotherSMaidenName
	{
		get{
			XPN ret = null;
			try
			{
			IType t = this.GetField(42, 0);
				ret = (XPN)t;
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
	/// Returns Nationality Code(GT1-43).
	///</summary>
	public CE NationalityCode
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(43, 0);
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
	/// Returns Ethnic Group(GT1-44).
	///</summary>
	public IS EthnicGroup
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(44, 0);
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
	/// Returns a single repetition of Contact Person's Name(GT1-45).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XPN GetContactPersonSName(int rep)
	{
			XPN ret = null;
			try
			{
			IType t = this.GetField(45, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Contact Person's Name (GT1-45).
   ///</summary>
  public XPN[] GetContactPersonSName() {
     XPN[] ret = null;
    try {
        IType[] t = this.GetField(45);  
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
  /// Returns the total repetitions of Contact Person's Name (GT1-45).
   ///</summary>
  public int ContactPersonSNameRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(45);
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
	/// Returns a single repetition of Contact Person’s Telephone Number(GT1-46).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XTN GetContactPersonSTelephoneNumber(int rep)
	{
			XTN ret = null;
			try
			{
			IType t = this.GetField(46, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Contact Person’s Telephone Number (GT1-46).
   ///</summary>
  public XTN[] GetContactPersonSTelephoneNumber() {
     XTN[] ret = null;
    try {
        IType[] t = this.GetField(46);  
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
  /// Returns the total repetitions of Contact Person’s Telephone Number (GT1-46).
   ///</summary>
  public int ContactPersonSTelephoneNumberRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(46);
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
	/// Returns Contact Reason(GT1-47).
	///</summary>
	public CE ContactReason
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(47, 0);
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
	/// Returns Contact Relationship Code(GT1-48).
	///</summary>
	public IS ContactRelationshipCode
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(48, 0);
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
	/// Returns Job Title(GT1-49).
	///</summary>
	public ST JobTitle
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(49, 0);
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
	/// Returns Job Code/Class(GT1-50).
	///</summary>
	public JCC JobCodeClass
	{
		get{
			JCC ret = null;
			try
			{
			IType t = this.GetField(50, 0);
				ret = (JCC)t;
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
	/// Returns a single repetition of Guarantor Employer's Organization Name(GT1-51).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XON GetGuarantorEmployerSOrganizationName(int rep)
	{
			XON ret = null;
			try
			{
			IType t = this.GetField(51, rep);
				ret = (XON)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Guarantor Employer's Organization Name (GT1-51).
   ///</summary>
  public XON[] GetGuarantorEmployerSOrganizationName() {
     XON[] ret = null;
    try {
        IType[] t = this.GetField(51);  
        ret = new XON[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XON)t[i];
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
  /// Returns the total repetitions of Guarantor Employer's Organization Name (GT1-51).
   ///</summary>
  public int GuarantorEmployerSOrganizationNameRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(51);
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
	/// Returns Handicap(GT1-52).
	///</summary>
	public IS Handicap
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(52, 0);
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
	/// Returns Job Status(GT1-53).
	///</summary>
	public IS JobStatus
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(53, 0);
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
	/// Returns Guarantor Financial Class(GT1-54).
	///</summary>
	public FC GuarantorFinancialClass
	{
		get{
			FC ret = null;
			try
			{
			IType t = this.GetField(54, 0);
				ret = (FC)t;
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
	/// Returns Guarantor Race(GT1-55).
	///</summary>
	public IS GuarantorRace
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(55, 0);
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


}}