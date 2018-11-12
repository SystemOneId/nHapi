using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
///<summary>
///Represents the MFN_M03_MF_TEST Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: MFE (Master File Entry) </li>
///<li>1: OM1 (General Segment) </li>
///<li>2: Hxx (any HL7 segment) </li>
///</ol>
///</summary>
[Serializable]
public class MFN_M03_MF_TEST : AbstractGroup {

	///<summary> 
	/// Creates a new MFN_M03_MF_TEST Group.
	///</summary>
	public MFN_M03_MF_TEST(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(MFE), true, false);
	      this.add(typeof(OM1), true, false);
	      this.add(typeof(Hxx), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFN_M03_MF_TEST - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns MFE (Master File Entry) - creates it if necessary
	///</summary>
	public MFE MFE { 
get{
	   MFE ret = null;
	   try {
	      ret = (MFE)this.GetStructure("MFE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns OM1 (General Segment) - creates it if necessary
	///</summary>
	public OM1 OM1 { 
get{
	   OM1 ret = null;
	   try {
	      ret = (OM1)this.GetStructure("OM1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns Hxx (any HL7 segment) - creates it if necessary
	///</summary>
	public Hxx Hxx { 
get{
	   Hxx ret = null;
	   try {
	      ret = (Hxx)this.GetStructure("Hxx");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
