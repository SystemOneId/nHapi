using System;
using System.Collections.Generic;
using System.Text;

namespace NHapi.Base
{

    [global::System.Serializable]
    public class SQLException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public SQLException() { }
        public SQLException(string message) : base(message) { }
        public SQLException(string message, Exception inner) : base(message, inner) { }
        protected SQLException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
