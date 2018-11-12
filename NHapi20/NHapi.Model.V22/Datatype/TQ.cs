using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V22.Datatype
{

///<summary>
/// <p>The HL7 TQ (timing quantity) data type.  Consists of the following components: </p><ol>
/// <li>Quantity (CQ_QUANTITY)</li>
/// <li>interval (CM_RI)</li>
/// <li>duration (ST)</li>
/// <li>start date/time (TS)</li>
/// <li>end date/time (TS)</li>
/// <li>priority (ID)</li>
/// <li>condition (ST)</li>
/// <li>text (TX) (TX)</li>
/// <li>conjunction (ID)</li>
/// <li>order sequencing (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class TQ : AbstractType, IComposite{
	private IType[] data;

	///<summary>
	/// Creates a TQ.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public TQ(IMessage message) : this(message, null){}

	///<summary>
	/// Creates a TQ.
	/// <param name="message">The Message to which this Type belongs</param>
	/// <param name="description">The description of this type</param>
	///</summary>
	public TQ(IMessage message, string description) : base(message, description){
		data = new IType[10];
		data[0] = new CQ_QUANTITY(message,"Quantity");
		data[1] = new CM_RI(message,"Interval");
		data[2] = new ST(message,"Duration");
		data[3] = new TS(message,"Start date/time");
		data[4] = new TS(message,"End date/time");
		data[5] = new ID(message, 0,"Priority");
		data[6] = new ST(message,"Condition");
		data[7] = new TX(message,"Text (TX)");
		data[8] = new ID(message, 0,"Conjunction");
		data[9] = new ST(message,"Order sequencing");
	}

	///<summary>
	/// Returns an array containing the data elements.
	///</summary>
	public IType[] Components
	{ 
		get{
			return this.data; 
		}
	}

	///<summary>
	/// Returns an individual data component.
	/// @throws DataTypeException if the given element number is out of range.
	///<param name="index">The index item to get (zero based)</param>
	///<returns>The data component (as a type) at the requested number (ordinal)</returns>
	///</summary>
	public IType this[int index] { 

get{
		try { 
			return this.data[index]; 
		} catch (System.ArgumentOutOfRangeException) { 
			throw new DataTypeException("Element " + index + " doesn't exist in 10 element TQ composite"); 
		} 
	} 
	} 
	///<summary>
	/// Returns Quantity (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CQ_QUANTITY Quantity {
get{
	   CQ_QUANTITY ret = null;
	   try {
	      ret = (CQ_QUANTITY)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns interval (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CM_RI Interval {
get{
	   CM_RI ret = null;
	   try {
	      ret = (CM_RI)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns duration (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST Duration {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[2];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns start date/time (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TS StartDateTime {
get{
	   TS ret = null;
	   try {
	      ret = (TS)this[3];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns end date/time (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TS EndDateTime {
get{
	   TS ret = null;
	   try {
	      ret = (TS)this[4];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns priority (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID Priority {
get{
	   ID ret = null;
	   try {
	      ret = (ID)this[5];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns condition (component #6).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST Condition {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[6];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns text (TX) (component #7).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TX Text {
get{
	   TX ret = null;
	   try {
	      ret = (TX)this[7];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns conjunction (component #8).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID Conjunction {
get{
	   ID ret = null;
	   try {
	      ret = (ID)this[8];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns order sequencing (component #9).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST OrderSequencing {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[9];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}