using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment{

///<summary>
/// Represents an HL7 BLG message segment. 
/// This segment has the following fields:<ol>
///<li>BLG-1: WHEN TO CHARGE (CM)</li>
///<li>BLG-2: CHARGE TYPE (ID)</li>
///<li>BLG-3: ACCOUNT ID (CM)</li>
///</ol>
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class BLG : AbstractSegment  {

  /**
   * Creates a BLG (BILLING) segment object that belongs to the given 
   * message.  
   */
	public BLG(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(CM), false, 1, 15, new System.Object[]{message}, "WHEN TO CHARGE");
       this.add(typeof(ID), false, 1, 50, new System.Object[]{message, 122}, "CHARGE TYPE");
       this.add(typeof(CM), false, 1, 100, new System.Object[]{message}, "ACCOUNT ID");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns WHEN TO CHARGE(BLG-1).
	///</summary>
	public CM WHENTOCHARGE
	{
		get{
			CM ret = null;
			try
			{
			IType t = this.GetField(1, 0);
				ret = (CM)t;
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
	/// Returns CHARGE TYPE(BLG-2).
	///</summary>
	public ID CHARGETYPE
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(2, 0);
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
	/// Returns ACCOUNT ID(BLG-3).
	///</summary>
	public CM ACCOUNTID
	{
		get{
			CM ret = null;
			try
			{
			IType t = this.GetField(3, 0);
				ret = (CM)t;
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