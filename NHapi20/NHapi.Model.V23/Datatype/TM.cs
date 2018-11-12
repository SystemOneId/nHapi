using System;

using NHapi.Base.Model;
namespace NHapi.Model.V23.Datatype
{
/// <summary>/// Summary description for TM.
/// </summary>
public class TM: NHapi.Base.Model.Primitive.TM
{
/// <summary>Return the version
/// <returns>2.3</returns>
///</summary>

            virtual public System.String Version
            {
			    get
			    {
				    return "2.3";
			    }
		    }
            


                ///<summary>Construct the type
                ///<param name="theMessage">message to which this Type belongs</param>
                ///</summary>
                public TM(IMessage theMessage):base(theMessage)
                {}
                


                ///<summary>Construct the type
                ///<param name="message">message to which this Type belongs</param>
                ///<param name="description">The description of this type</param>
                ///</summary>
		        public TM(IMessage message, string description) : base(message,description)
    	        {}
                }}