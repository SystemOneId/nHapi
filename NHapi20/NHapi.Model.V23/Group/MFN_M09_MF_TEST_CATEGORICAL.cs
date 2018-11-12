using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
///<summary>
///Represents the MFN_M09_MF_TEST_CATEGORICAL Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: MFE (Master file entry segment) </li>
///<li>1: MFN_M09_MF_TEST_CAT_DETAIL (a Group object) optional </li>
///</ol>
///</summary>
[Serializable]
public class MFN_M09_MF_TEST_CATEGORICAL : AbstractGroup {

	///<summary> 
	/// Creates a new MFN_M09_MF_TEST_CATEGORICAL Group.
	///</summary>
	public MFN_M09_MF_TEST_CATEGORICAL(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(MFE), true, false);
	      this.add(typeof(MFN_M09_MF_TEST_CAT_DETAIL), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFN_M09_MF_TEST_CATEGORICAL - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns MFE (Master file entry segment) - creates it if necessary
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
	/// Returns MFN_M09_MF_TEST_CAT_DETAIL (a Group object) - creates it if necessary
	///</summary>
	public MFN_M09_MF_TEST_CAT_DETAIL MF_TEST_CAT_DETAIL { 
get{
	   MFN_M09_MF_TEST_CAT_DETAIL ret = null;
	   try {
	      ret = (MFN_M09_MF_TEST_CAT_DETAIL)this.GetStructure("MF_TEST_CAT_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
