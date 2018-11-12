using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V25.Datatype
{

///<summary>
/// <p>The HL7 HD (Hierarchic Designator) data type.  Consists of the following components: </p><ol>
/// <li>Namespace ID (IS)</li>
/// <li>Universal ID (ST)</li>
/// <li>Universal ID Type (ID)</li>
/// </ol>
///</summary>
[Serializable]
public class HD : AbstractType, IComposite{
	private IType[] data;

	///<summary>
	/// Creates a HD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public HD(IMessage message) : this(message, null){}

	///<summary>
	/// Creates a HD.
	/// <param name="message">The Message to which this Type belongs</param>
	/// <param name="description">The description of this type</param>
	///</summary>
	public HD(IMessage message, string description) : base(message, description){
		data = new IType[3];
		data[0] = new IS(message, 300,"Namespace ID");
		data[1] = new ST(message,"Universal ID");
		data[2] = new ID(message, 301,"Universal ID Type");
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
			throw new DataTypeException("Element " + index + " doesn't exist in 3 element HD composite"); 
		} 
	} 
	} 
	///<summary>
	/// Returns Namespace ID (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS NamespaceID {
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
	/// Returns Universal ID (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST UniversalID {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Universal ID Type (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID UniversalIDType {
get{
	   ID ret = null;
	   try {
	      ret = (ID)this[2];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}