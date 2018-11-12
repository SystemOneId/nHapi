/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "HL7Exception.java".  Description: 
/// "Represents an exception encountered while processing 
/// an HL7 message" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  �GPL�), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
using NHapi.Base.Log;
using NHapi.Base.Util;
using NHapi.Base.Model;

namespace NHapi.Base
{

    /// <summary> Represents an exception encountered while processing 
    /// an HL7 message.  
    /// </summary>
    /// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
    /// </author>
    [Serializable]
    public class HL7Exception : System.Exception
    {
        /// <summary> Returns the name of the segment where the error occurred, if this has been set
        /// (null otherwise).
        /// </summary>
        /// <summary> Sets the name of the segment where the error occurred. </summary>
        virtual public System.String SegmentName
        {
            get
            {
                return this.segment;
            }

            set
            {
                this.segment = value;
            }

        }
        /// <summary> Returns the sequence number of the segment where the error occurred (if there 
        /// are multiple segments with the same name) if this has been set, -1 otherwise - 
        /// numbering starts at 1.
        /// </summary>
        /// <summary> Sets the sequence number of the segment where the error occurred if there 
        /// are multiple segments with the same name (ie the sequenceNum'th segment 
        /// with the name specified in <code>setSegmentName</code>).  Numbering 
        /// starts at 1.
        /// </summary>
        virtual public int SegmentRepetition
        {
            get
            {
                return this.segmentRep;
            }

            set
            {
                this.segmentRep = value;
            }

        }
        /// <summary> Returns the field number within the segment where the error occurred if it has been 
        /// set, -1 otherwise; numbering starts at 1.
        /// </summary>
        /// <summary> Sets the field number (within a segment) where the error occurred; numbering 
        /// starts at 1. 
        /// </summary>
        virtual public int FieldPosition
        {
            get
            {
                return this.fieldPosition;
            }

            set
            {
                this.fieldPosition = value;
            }

        }
        /// <summary> Overrides Throwable.getMessage() to add the field location of the problem if 
        /// available.
        /// </summary>
        public override System.String Message
        {
            get
            {
                System.Text.StringBuilder msg = new System.Text.StringBuilder();
                msg.Append(base.Message);
                if (SegmentName != null)
                {
                    msg.Append(": Segment: ");
                    msg.Append(SegmentName);
                }
                if (SegmentRepetition != -1)
                {
                    msg.Append(" (rep ");
                    msg.Append(SegmentRepetition);
                    msg.Append(")");
                }
                if (FieldPosition != -1)
                {
                    msg.Append(" Field #");
                    msg.Append(FieldPosition);
                }
                return msg.ToString();
            }

        }

        private static readonly IHapiLog ourLog;

        /// <summary>
        /// Acknowledgement Application Accept 
        /// </summary>
        public const int ACK_AA = 1;
        /// <summary>
        /// Acknowledgement Application Error
        /// </summary>
        public const int ACK_AE = 2;
        /// <summary>
        /// Acknowledgement Application Reject
        /// </summary>
        public const int ACK_AR = 3;

        /// <summary>
        /// Message accepted
        /// </summary>
        public const int MESSAGE_ACCEPTED = 0;
        /// <summary>
        /// Segment sequence error
        /// </summary>
        public const int SEGMENT_SEQUENCE_ERROR = 100;
        /// <summary>
        /// Required field missing
        /// </summary>
        public const int REQUIRED_FIELD_MISSING = 101;
        /// <summary>
        /// Date type error
        /// </summary>
        public const int DATA_TYPE_ERROR = 102;
        /// <summary>
        /// Table value not found
        /// </summary>
        public const int TABLE_VALUE_NOT_FOUND = 103;
        /// <summary>
        /// Unsupported message type
        /// </summary>
        public const int UNSUPPORTED_MESSAGE_TYPE = 200;
        /// <summary>
        /// Unsupported event code
        /// </summary>
        public const int UNSUPPORTED_EVENT_CODE = 201;
        /// <summary>
        /// Unsupported processing id
        /// </summary>
        public const int UNSUPPORTED_PROCESSING_ID = 202;
        /// <summary>
        /// Unsupported version id
        /// </summary>
        public const int UNSUPPORTED_VERSION_ID = 203;
        /// <summary>
        /// Unknown key id
        /// </summary>
        public const int UNKNOWN_KEY_IDENTIFIER = 204;
        /// <summary>
        /// Duplicate key id
        /// </summary>
        public const int DUPLICATE_KEY_IDENTIFIER = 205;
        /// <summary>
        /// Application record locked
        /// </summary>
        public const int APPLICATION_RECORD_LOCKED = 206;
        /// <summary>
        /// Application error
        /// </summary>
        public const int APPLICATION_INTERNAL_ERROR = 207;

        private System.String segment = null;
        private int segmentRep = -1;
        private int fieldPosition = -1;
        private int errCode = -1;

        /// <summary> Creates an HL7Exception.
        /// <param name="message">The error message</param>
        /// <param name="errorCondition">a code describing the the error condition, from HL7
        /// table 0357 (see section 2.16.8 of standard v 2.4) - HL7Exception defines 
        /// these codes as integer constants that can be used here (e.g. 
        /// HL7Exception.UNSUPPORTED_MESSAGE_TYPE)
        /// </param>
        /// <param name="cause">The exception that caused this exception to be thrown.
        /// </param>
        /// </summary>
        public HL7Exception(System.String message, int errorCondition, System.Exception cause)
            : base(message, cause)
        {
            this.errCode = errorCondition;
        }

        /// <summary> Creates an HL7Exception.
        /// <param name="message">the error message</param>
        /// <param name="errorCondition">a code describing the the error condition, from HL7
        /// table 0357 (see section 2.16.8 of standard v 2.4) - HL7Exception defines 
        /// these codes as integer constants that can be used here (e.g. 
        /// HL7Exception.UNSUPPORTED_MESSAGE_TYPE)
        /// </param>
        /// </summary>
        public HL7Exception(System.String message, int errorCondition)
            : base(message)
        {
            this.errCode = errorCondition;
        }

        /// <summary> Creates an HL7Exception with the code APPLICATION_INTERNAL_ERROR
        /// <param name="cause">The excption that caused this exception tobe thrown.
        /// </param>
        /// <param name="message">the error message</param>
        /// </summary>
        public HL7Exception(System.String message, System.Exception cause)
            : base(message, cause)
        {
            this.errCode = HL7Exception.APPLICATION_INTERNAL_ERROR;
        }

        /// <summary> Creates an HL7Exception with the code APPLICATION_INTERNAL_ERROR</summary>
        public HL7Exception(System.String message)
            : base(message)
        {
            this.errCode = HL7Exception.APPLICATION_INTERNAL_ERROR;
        }

        /// <summary> Populates the given error segment with information from this Exception.</summary>
        public virtual void populate(ISegment errorSegment)
        {
            //make sure it's an ERR
            if (!errorSegment.GetStructureName().Equals("ERR"))
                throw new HL7Exception("Can only populate an ERR segment with an exception -- got: " + errorSegment.GetType().FullName);

            int rep = errorSegment.GetField(1).Length; //append after existing reps

            if (this.SegmentName != null)
                Terser.Set(errorSegment, 1, rep, 1, 1, this.SegmentName);

            if (this.SegmentRepetition >= 0)
                Terser.Set(errorSegment, 1, rep, 2, 1, System.Convert.ToString(this.SegmentRepetition));

            if (this.FieldPosition >= 0)
                Terser.Set(errorSegment, 1, rep, 3, 1, System.Convert.ToString(this.FieldPosition));

            Terser.Set(errorSegment, 1, rep, 4, 1, System.Convert.ToString(this.errCode));
            Terser.Set(errorSegment, 1, rep, 4, 3, "hl70357");
            Terser.Set(errorSegment, 1, rep, 4, 5, this.Message);

            //try to get error condition text
            try
            {
                System.String desc = TableRepository.Instance.getDescription(357, System.Convert.ToString(this.errCode));
                Terser.Set(errorSegment, 1, rep, 4, 2, desc);
            }
            catch (LookupException e)
            {
                ourLog.Debug("Warning: LookupException getting error condition text (are we connected to a TableRepository?)", e);
            }
        }
        static HL7Exception()
        {
            ourLog = HapiLogFactory.GetHapiLog(typeof(HL7Exception));
        }
    }
}