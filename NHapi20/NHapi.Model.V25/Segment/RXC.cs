using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V25.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V25.Segment{

///<summary>
/// Represents an HL7 RXC message segment. 
/// This segment has the following fields:<ol>
///<li>RXC-1: RX Component Type (ID)</li>
///<li>RXC-2: Component Code (CE)</li>
///<li>RXC-3: Component Amount (NM)</li>
///<li>RXC-4: Component Units (CE)</li>
///<li>RXC-5: Component Strength (NM)</li>
///<li>RXC-6: Component Strength Units (CE)</li>
///<li>RXC-7: Supplementary Code (CE)</li>
///<li>RXC-8: Component Drug Strength Volume (NM)</li>
///<li>RXC-9: Component Drug Strength Volume Units (CWE)</li>
///</ol>
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class RXC : AbstractSegment  {

  /**
   * Creates a RXC (Pharmacy/Treatment Component Order) segment object that belongs to the given 
   * message.  
   */
	public RXC(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 166}, "RX Component Type");
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Component Code");
       this.add(typeof(NM), true, 1, 20, new System.Object[]{message}, "Component Amount");
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Component Units");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Component Strength");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Component Strength Units");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Supplementary Code");
       this.add(typeof(NM), false, 1, 5, new System.Object[]{message}, "Component Drug Strength Volume");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Component Drug Strength Volume Units");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns RX Component Type(RXC-1).
	///</summary>
	public ID RXComponentType
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(1, 0);
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
	/// Returns Component Code(RXC-2).
	///</summary>
	public CE ComponentCode
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
	/// Returns Component Amount(RXC-3).
	///</summary>
	public NM ComponentAmount
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
	/// Returns Component Units(RXC-4).
	///</summary>
	public CE ComponentUnits
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(4, 0);
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
	/// Returns Component Strength(RXC-5).
	///</summary>
	public NM ComponentStrength
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
	/// Returns Component Strength Units(RXC-6).
	///</summary>
	public CE ComponentStrengthUnits
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(6, 0);
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
	/// Returns a single repetition of Supplementary Code(RXC-7).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CE GetSupplementaryCode(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(7, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Supplementary Code (RXC-7).
   ///</summary>
  public CE[] GetSupplementaryCode() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(7);  
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
  /// Returns the total repetitions of Supplementary Code (RXC-7).
   ///</summary>
  public int SupplementaryCodeRepetitionsUsed
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
	/// Returns Component Drug Strength Volume(RXC-8).
	///</summary>
	public NM ComponentDrugStrengthVolume
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
	/// Returns Component Drug Strength Volume Units(RXC-9).
	///</summary>
	public CWE ComponentDrugStrengthVolumeUnits
	{
		get{
			CWE ret = null;
			try
			{
			IType t = this.GetField(9, 0);
				ret = (CWE)t;
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