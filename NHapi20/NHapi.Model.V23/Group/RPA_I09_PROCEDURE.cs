using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
///<summary>
///Represents the RPA_I09_PROCEDURE Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: PR1 (Procedures) </li>
///<li>1: RPA_I09_AUTHORIZATION (a Group object) optional </li>
///</ol>
///</summary>
[Serializable]
public class RPA_I09_PROCEDURE : AbstractGroup {

	///<summary> 
	/// Creates a new RPA_I09_PROCEDURE Group.
	///</summary>
	public RPA_I09_PROCEDURE(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(PR1), true, false);
	      this.add(typeof(RPA_I09_AUTHORIZATION), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RPA_I09_PROCEDURE - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns PR1 (Procedures) - creates it if necessary
	///</summary>
	public PR1 PR1 { 
get{
	   PR1 ret = null;
	   try {
	      ret = (PR1)this.GetStructure("PR1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns RPA_I09_AUTHORIZATION (a Group object) - creates it if necessary
	///</summary>
	public RPA_I09_AUTHORIZATION AUTHORIZATION { 
get{
	   RPA_I09_AUTHORIZATION ret = null;
	   try {
	      ret = (RPA_I09_AUTHORIZATION)this.GetStructure("AUTHORIZATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
