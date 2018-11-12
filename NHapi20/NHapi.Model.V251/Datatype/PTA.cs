using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V251.Datatype
{

///<summary>
/// <p>The HL7 PTA (Policy Type and Amount) data type.  Consists of the following components: </p><ol>
/// <li>Policy Type (IS)</li>
/// <li>Amount Class (IS)</li>
/// <li>Money or Percentage Quantity (NM)</li>
/// <li>Money or Percentage (MOP)</li>
/// </ol>
///</summary>
[Serializable]
public class PTA : AbstractType, IComposite{
	private IType[] data;

	///<summary>
	/// Creates a PTA.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public PTA(IMessage message) : this(message, null){}

	///<summary>
	/// Creates a PTA.
	/// <param name="message">The Message to which this Type belongs</param>
	/// <param name="description">The description of this type</param>
	///</summary>
	public PTA(IMessage message, string description) : base(message, description){
		data = new IType[4];
		data[0] = new IS(message, 147,"Policy Type");
		data[1] = new IS(message, 193,"Amount Class");
		data[2] = new NM(message,"Money or Percentage Quantity");
		data[3] = new MOP(message,"Money or Percentage");
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
			throw new DataTypeException("Element " + index + " doesn't exist in 4 element PTA composite"); 
		} 
	} 
	} 
	///<summary>
	/// Returns Policy Type (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS PolicyType {
get{
	   IS ret = null;
	   try {
	      ret = (IS)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Amount Class (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS AmountClass {
get{
	   IS ret = null;
	   try {
	      ret = (IS)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Money or Percentage Quantity (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM MoneyOrPercentageQuantity {
get{
	   NM ret = null;
	   try {
	      ret = (NM)this[2];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Money or Percentage (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public MOP MoneyOrPercentage {
get{
	   MOP ret = null;
	   try {
	      ret = (MOP)this[3];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}