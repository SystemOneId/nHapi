using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V251.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V251.Segment{

///<summary>
/// Represents an HL7 OM7 message segment. 
/// This segment has the following fields:<ol>
///<li>OM7-1: Sequence Number - Test/Observation Master File (NM)</li>
///<li>OM7-2: Universal Service Identifier (CE)</li>
///<li>OM7-3: Category Identifier (CE)</li>
///<li>OM7-4: Category Description (TX)</li>
///<li>OM7-5: Category Synonym (ST)</li>
///<li>OM7-6: Effective Test/Service Start Date/Time (TS)</li>
///<li>OM7-7: Effective Test/Service End Date/Time (TS)</li>
///<li>OM7-8: Test/Service Default Duration Quantity (NM)</li>
///<li>OM7-9: Test/Service Default Duration Units (CE)</li>
///<li>OM7-10: Test/Service Default Frequency (IS)</li>
///<li>OM7-11: Consent Indicator (ID)</li>
///<li>OM7-12: Consent Identifier (CE)</li>
///<li>OM7-13: Consent Effective Start Date/Time (TS)</li>
///<li>OM7-14: Consent Effective End Date/Time (TS)</li>
///<li>OM7-15: Consent Interval Quantity (NM)</li>
///<li>OM7-16: Consent Interval Units (CE)</li>
///<li>OM7-17: Consent Waiting Period Quantity (NM)</li>
///<li>OM7-18: Consent Waiting Period Units (CE)</li>
///<li>OM7-19: Effective Date/Time of Change (TS)</li>
///<li>OM7-20: Entered By (XCN)</li>
///<li>OM7-21: Orderable-at Location (PL)</li>
///<li>OM7-22: Formulary Status (IS)</li>
///<li>OM7-23: Special Order Indicator (ID)</li>
///<li>OM7-24: Primary Key Value - CDM (CE)</li>
///</ol>
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class OM7 : AbstractSegment  {

  /**
   * Creates a OM7 (Additional Basic Attributes) segment object that belongs to the given 
   * message.  
   */
	public OM7(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(NM), true, 1, 4, new System.Object[]{message}, "Sequence Number - Test/Observation Master File");
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Universal Service Identifier");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Category Identifier");
       this.add(typeof(TX), false, 1, 200, new System.Object[]{message}, "Category Description");
       this.add(typeof(ST), false, 0, 200, new System.Object[]{message}, "Category Synonym");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Effective Test/Service Start Date/Time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Effective Test/Service End Date/Time");
       this.add(typeof(NM), false, 1, 5, new System.Object[]{message}, "Test/Service Default Duration Quantity");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Test/Service Default Duration Units");
       this.add(typeof(IS), false, 1, 60, new System.Object[]{message, 335}, "Test/Service Default Frequency");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Consent Indicator");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Consent Identifier");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Consent Effective Start Date/Time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Consent Effective End Date/Time");
       this.add(typeof(NM), false, 1, 5, new System.Object[]{message}, "Consent Interval Quantity");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Consent Interval Units");
       this.add(typeof(NM), false, 1, 5, new System.Object[]{message}, "Consent Waiting Period Quantity");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Consent Waiting Period Units");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Effective Date/Time of Change");
       this.add(typeof(XCN), false, 1, 250, new System.Object[]{message}, "Entered By");
       this.add(typeof(PL), false, 0, 200, new System.Object[]{message}, "Orderable-at Location");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 473}, "Formulary Status");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Special Order Indicator");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Primary Key Value - CDM");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Sequence Number - Test/Observation Master File(OM7-1).
	///</summary>
	public NM SequenceNumberTestObservationMasterFile
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(1, 0);
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
	/// Returns Universal Service Identifier(OM7-2).
	///</summary>
	public CE UniversalServiceIdentifier
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(2, 0);
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
	/// Returns a single repetition of Category Identifier(OM7-3).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CE GetCategoryIdentifier(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(3, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Category Identifier (OM7-3).
   ///</summary>
  public CE[] GetCategoryIdentifier() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(3);  
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
  /// Returns the total repetitions of Category Identifier (OM7-3).
   ///</summary>
  public int CategoryIdentifierRepetitionsUsed
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
	/// Returns Category Description(OM7-4).
	///</summary>
	public TX CategoryDescription
	{
		get{
			TX ret = null;
			try
			{
			IType t = this.GetField(4, 0);
				ret = (TX)t;
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
	/// Returns a single repetition of Category Synonym(OM7-5).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public ST GetCategorySynonym(int rep)
	{
			ST ret = null;
			try
			{
			IType t = this.GetField(5, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Category Synonym (OM7-5).
   ///</summary>
  public ST[] GetCategorySynonym() {
     ST[] ret = null;
    try {
        IType[] t = this.GetField(5);  
        ret = new ST[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
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
  /// Returns the total repetitions of Category Synonym (OM7-5).
   ///</summary>
  public int CategorySynonymRepetitionsUsed
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
	/// Returns Effective Test/Service Start Date/Time(OM7-6).
	///</summary>
	public TS EffectiveTestServiceStartDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(6, 0);
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
	/// Returns Effective Test/Service End Date/Time(OM7-7).
	///</summary>
	public TS EffectiveTestServiceEndDateTime
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
	/// Returns Test/Service Default Duration Quantity(OM7-8).
	///</summary>
	public NM TestServiceDefaultDurationQuantity
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
	/// Returns Test/Service Default Duration Units(OM7-9).
	///</summary>
	public CE TestServiceDefaultDurationUnits
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(9, 0);
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
	/// Returns Test/Service Default Frequency(OM7-10).
	///</summary>
	public IS TestServiceDefaultFrequency
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
	/// Returns Consent Indicator(OM7-11).
	///</summary>
	public ID ConsentIndicator
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(11, 0);
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
	/// Returns Consent Identifier(OM7-12).
	///</summary>
	public CE ConsentIdentifier
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(12, 0);
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
	/// Returns Consent Effective Start Date/Time(OM7-13).
	///</summary>
	public TS ConsentEffectiveStartDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(13, 0);
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
	/// Returns Consent Effective End Date/Time(OM7-14).
	///</summary>
	public TS ConsentEffectiveEndDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(14, 0);
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
	/// Returns Consent Interval Quantity(OM7-15).
	///</summary>
	public NM ConsentIntervalQuantity
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
	/// Returns Consent Interval Units(OM7-16).
	///</summary>
	public CE ConsentIntervalUnits
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
	/// Returns Consent Waiting Period Quantity(OM7-17).
	///</summary>
	public NM ConsentWaitingPeriodQuantity
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(17, 0);
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
	/// Returns Consent Waiting Period Units(OM7-18).
	///</summary>
	public CE ConsentWaitingPeriodUnits
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(18, 0);
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
	/// Returns Effective Date/Time of Change(OM7-19).
	///</summary>
	public TS EffectiveDateTimeOfChange
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(19, 0);
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
	/// Returns Entered By(OM7-20).
	///</summary>
	public XCN EnteredBy
	{
		get{
			XCN ret = null;
			try
			{
			IType t = this.GetField(20, 0);
				ret = (XCN)t;
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
	/// Returns a single repetition of Orderable-at Location(OM7-21).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public PL GetOrderableAtLocation(int rep)
	{
			PL ret = null;
			try
			{
			IType t = this.GetField(21, rep);
				ret = (PL)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Orderable-at Location (OM7-21).
   ///</summary>
  public PL[] GetOrderableAtLocation() {
     PL[] ret = null;
    try {
        IType[] t = this.GetField(21);  
        ret = new PL[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (PL)t[i];
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
  /// Returns the total repetitions of Orderable-at Location (OM7-21).
   ///</summary>
  public int OrderableAtLocationRepetitionsUsed
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
	/// Returns Formulary Status(OM7-22).
	///</summary>
	public IS FormularyStatus
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(22, 0);
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
	/// Returns Special Order Indicator(OM7-23).
	///</summary>
	public ID SpecialOrderIndicator
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(23, 0);
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
	/// Returns a single repetition of Primary Key Value - CDM(OM7-24).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CE GetPrimaryKeyValueCDM(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(24, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Primary Key Value - CDM (OM7-24).
   ///</summary>
  public CE[] GetPrimaryKeyValueCDM() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(24);  
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
  /// Returns the total repetitions of Primary Key Value - CDM (OM7-24).
   ///</summary>
  public int PrimaryKeyValueCDMRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(24);
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

}}