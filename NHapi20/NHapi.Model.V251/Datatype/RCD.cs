using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V251.Datatype
{

///<summary>
/// <p>The HL7 RCD (Row Column Definition) data type.  Consists of the following components: </p><ol>
/// <li>Segment Field Name (ST)</li>
/// <li>HL7 Data Type (ID)</li>
/// <li>Maximum Column Width (NM)</li>
/// </ol>
///</summary>
[Serializable]
public class RCD : AbstractType, IComposite{
	private IType[] data;

	///<summary>
	/// Creates a RCD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public RCD(IMessage message) : this(message, null){}

	///<summary>
	/// Creates a RCD.
	/// <param name="message">The Message to which this Type belongs</param>
	/// <param name="description">The description of this type</param>
	///</summary>
	public RCD(IMessage message, string description) : base(message, description){
		data = new IType[3];
		data[0] = new ST(message,"Segment Field Name");
		data[1] = new ID(message, 440,"HL7 Data Type");
		data[2] = new NM(message,"Maximum Column Width");
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
			throw new DataTypeException("Element " + index + " doesn't exist in 3 element RCD composite"); 
		} 
	} 
	} 
	///<summary>
	/// Returns Segment Field Name (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST SegmentFieldName {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns HL7 Data Type (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID HL7DataType {
get{
	   ID ret = null;
	   try {
	      ret = (ID)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Maximum Column Width (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM MaximumColumnWidth {
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
}}