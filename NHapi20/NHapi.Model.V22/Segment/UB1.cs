using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment{

///<summary>
/// Represents an HL7 UB1 message segment. 
/// This segment has the following fields:<ol>
///<li>UB1-1: Set ID - UB82 (SI)</li>
///<li>UB1-2: Blood deductible (43) (NM)</li>
///<li>UB1-3: Blood furnished pints of (40) (NM)</li>
///<li>UB1-4: Blood replaced pints (41) (NM)</li>
///<li>UB1-5: Blood not replaced pints (42) (NM)</li>
///<li>UB1-6: Co-insurance days (25) (NM)</li>
///<li>UB1-7: Condition code (35-39) (ID)</li>
///<li>UB1-8: Covered days (23) (NM)</li>
///<li>UB1-9: Non-covered days (24) (NM)</li>
///<li>UB1-10: Value amount and code (46-49) (CM_UVC)</li>
///<li>UB1-11: Number of grace days (90) (NM)</li>
///<li>UB1-12: Special program indicator (44) (ID)</li>
///<li>UB1-13: PSRO / UR approval indicator (87) (ID)</li>
///<li>UB1-14: PSRO / UR approved stay - from (88) (DT)</li>
///<li>UB1-15: PSRO / UR approved stay - to (89) (DT)</li>
///<li>UB1-16: Occurrence (28-32) (CM_OCD)</li>
///<li>UB1-17: Occurrence span (33) (ID)</li>
///<li>UB1-18: Occurrence span start date (33) (DT)</li>
///<li>UB1-19: Occurrence span end date (33) (DT)</li>
///<li>UB1-20: UB-82 locator 2 (ST)</li>
///<li>UB1-21: UB-82 locator 9 (ST)</li>
///<li>UB1-22: UB-82 locator 27 (ST)</li>
///<li>UB1-23: UB-82 locator 45 (ST)</li>
///</ol>
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class UB1 : AbstractSegment  {

  /**
   * Creates a UB1 (UB82 DATA) segment object that belongs to the given 
   * message.  
   */
	public UB1(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "Set ID - UB82");
       this.add(typeof(NM), false, 1, 1, new System.Object[]{message}, "Blood deductible (43)");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Blood furnished pints of (40)");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Blood replaced pints (41)");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Blood not replaced pints (42)");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Co-insurance days (25)");
       this.add(typeof(ID), false, 5, 2, new System.Object[]{message, 43}, "Condition code (35-39)");
       this.add(typeof(NM), false, 1, 3, new System.Object[]{message}, "Covered days (23)");
       this.add(typeof(NM), false, 1, 3, new System.Object[]{message}, "Non-covered days (24)");
       this.add(typeof(CM_UVC), false, 8, 12, new System.Object[]{message}, "Value amount and code (46-49)");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Number of grace days (90)");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0}, "Special program indicator (44)");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0}, "PSRO / UR approval indicator (87)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "PSRO / UR approved stay - from (88)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "PSRO / UR approved stay - to (89)");
       this.add(typeof(CM_OCD), false, 5, 20, new System.Object[]{message}, "Occurrence (28-32)");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0}, "Occurrence span (33)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Occurrence span start date (33)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Occurrence span end date (33)");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "UB-82 locator 2");
       this.add(typeof(ST), false, 1, 7, new System.Object[]{message}, "UB-82 locator 9");
       this.add(typeof(ST), false, 1, 8, new System.Object[]{message}, "UB-82 locator 27");
       this.add(typeof(ST), false, 1, 17, new System.Object[]{message}, "UB-82 locator 45");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Set ID - UB82(UB1-1).
	///</summary>
	public SI SetIDUB82
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
	/// Returns Blood deductible (43)(UB1-2).
	///</summary>
	public NM BloodDeductible
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(2, 0);
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
	/// Returns Blood furnished pints of (40)(UB1-3).
	///</summary>
	public NM BloodFurnishedPintsOf
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(3, 0);
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
	/// Returns Blood replaced pints (41)(UB1-4).
	///</summary>
	public NM BloodReplacedPints
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(4, 0);
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
	/// Returns Blood not replaced pints (42)(UB1-5).
	///</summary>
	public NM BloodNotReplacedPints
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(5, 0);
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
	/// Returns Co-insurance days (25)(UB1-6).
	///</summary>
	public NM CoInsuranceDays
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(6, 0);
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
	/// Returns a single repetition of Condition code (35-39)(UB1-7).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public ID GetConditionCode3539(int rep)
	{
			ID ret = null;
			try
			{
			IType t = this.GetField(7, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Condition code (35-39) (UB1-7).
   ///</summary>
  public ID[] GetConditionCode3539() {
     ID[] ret = null;
    try {
        IType[] t = this.GetField(7);  
        ret = new ID[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ID)t[i];
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
  /// Returns the total repetitions of Condition code (35-39) (UB1-7).
   ///</summary>
  public int ConditionCode3539RepetitionsUsed
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
	/// Returns Covered days (23)(UB1-8).
	///</summary>
	public NM CoveredDays
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(8, 0);
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
	/// Returns Non-covered days (24)(UB1-9).
	///</summary>
	public NM NonCoveredDays
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(9, 0);
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
	/// Returns a single repetition of Value amount and code (46-49)(UB1-10).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CM_UVC GetValueAmountAndCode4649(int rep)
	{
			CM_UVC ret = null;
			try
			{
			IType t = this.GetField(10, rep);
				ret = (CM_UVC)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Value amount and code (46-49) (UB1-10).
   ///</summary>
  public CM_UVC[] GetValueAmountAndCode4649() {
     CM_UVC[] ret = null;
    try {
        IType[] t = this.GetField(10);  
        ret = new CM_UVC[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_UVC)t[i];
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
  /// Returns the total repetitions of Value amount and code (46-49) (UB1-10).
   ///</summary>
  public int ValueAmountAndCode4649RepetitionsUsed
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
	/// Returns Number of grace days (90)(UB1-11).
	///</summary>
	public NM NumberOfGraceDays
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(11, 0);
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
	/// Returns Special program indicator (44)(UB1-12).
	///</summary>
	public ID SpecialProgramIndicator
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(12, 0);
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
	/// Returns PSRO / UR approval indicator (87)(UB1-13).
	///</summary>
	public ID PSROURApprovalIndicator
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(13, 0);
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
	/// Returns PSRO / UR approved stay - from (88)(UB1-14).
	///</summary>
	public DT PSROURApprovedStayFrom
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
	/// Returns PSRO / UR approved stay - to (89)(UB1-15).
	///</summary>
	public DT PSROURApprovedStayTo
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(15, 0);
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
	/// Returns a single repetition of Occurrence (28-32)(UB1-16).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CM_OCD GetOccurrence2832(int rep)
	{
			CM_OCD ret = null;
			try
			{
			IType t = this.GetField(16, rep);
				ret = (CM_OCD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Occurrence (28-32) (UB1-16).
   ///</summary>
  public CM_OCD[] GetOccurrence2832() {
     CM_OCD[] ret = null;
    try {
        IType[] t = this.GetField(16);  
        ret = new CM_OCD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_OCD)t[i];
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
  /// Returns the total repetitions of Occurrence (28-32) (UB1-16).
   ///</summary>
  public int Occurrence2832RepetitionsUsed
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
	/// Returns Occurrence span (33)(UB1-17).
	///</summary>
	public ID OccurrenceSpan
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(17, 0);
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
	/// Returns Occurrence span start date (33)(UB1-18).
	///</summary>
	public DT OccurrenceSpanStartDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(18, 0);
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
	/// Returns Occurrence span end date (33)(UB1-19).
	///</summary>
	public DT OccurrenceSpanEndDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(19, 0);
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
	/// Returns UB-82 locator 2(UB1-20).
	///</summary>
	public ST UB82Locator2
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(20, 0);
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
	/// Returns UB-82 locator 9(UB1-21).
	///</summary>
	public ST UB82Locator9
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(21, 0);
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
	/// Returns UB-82 locator 27(UB1-22).
	///</summary>
	public ST UB82Locator27
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(22, 0);
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
	/// Returns UB-82 locator 45(UB1-23).
	///</summary>
	public ST UB82Locator45
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


}}