using System;
using NHapi.Base.Log;
using NHapi.Model.V22.Group;
using NHapi.Model.V22.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V22.Message

{
///<summary>
/// Represents a MFQ_M03 message structure (see chapter [AAA]). This structure contains the 
/// following elements:
///<ol>
///<li>0: MSH (MESSAGE HEADER) </li>
///<li>1: QRD (QUERY DEFINITION) </li>
///<li>2: QRF (QUERY FILTER) optional </li>
///<li>3: DSC (CONTINUATION POINTER) optional </li>
///</ol>
///</summary>
[Serializable]
public class MFQ_M03 : AbstractMessage  {

	///<summary> 
	/// Creates a new MFQ_M03 Group with custom IModelClassFactory.
	///</summary>
	public MFQ_M03(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new MFQ_M03 Group with DefaultModelClassFactory. 
	///</summary> 
	public MFQ_M03() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for MFQ_M03.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(QRD), true, false);
	      this.add(typeof(QRF), false, false);
	      this.add(typeof(DSC), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFQ_M03 - this is probably a bug in the source code generator.", e);
	   }
	}


	public override string Version
		{
			get{
			return Constants.VERSION;
			}
		}
	///<summary>
	/// Returns MSH (MESSAGE HEADER) - creates it if necessary
	///</summary>
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.GetStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns QRD (QUERY DEFINITION) - creates it if necessary
	///</summary>
	public QRD QRD { 
get{
	   QRD ret = null;
	   try {
	      ret = (QRD)this.GetStructure("QRD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns QRF (QUERY FILTER) - creates it if necessary
	///</summary>
	public QRF QRF { 
get{
	   QRF ret = null;
	   try {
	      ret = (QRF)this.GetStructure("QRF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns DSC (CONTINUATION POINTER) - creates it if necessary
	///</summary>
	public DSC DSC { 
get{
	   DSC ret = null;
	   try {
	      ret = (DSC)this.GetStructure("DSC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
