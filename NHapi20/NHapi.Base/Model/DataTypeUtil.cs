/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "DataTypeUtil.java".  Description:
/// "This class is used to provide utility functions for other datatype classes and methods."
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2001.  All Rights Reserved.
/// 
/// Contributor(s): ______________________________________.
/// 
/// Alternatively, the contents of this file may be used under the terms of the
/// GNU General Public License (the  �GPL�), in which case the provisions of the GPL are
/// applicable instead of those above.  If you wish to allow use of your version of this
/// file only under the terms of the GPL and not to allow others to use your version
/// of this file under the MPL, indicate your decision by deleting  the provisions above
/// and replace  them with the notice and other provisions required by the GPL License.
/// If you do not delete the provisions above, a recipient may use your version of
/// this file under either the MPL or the GPL.
/// 
/// </summary>
using System;
namespace NHapi.Base.Model
{

    /// <summary> This class is used to provide utility functions for other datatype classes and methods.</summary>

    public class DataTypeUtil
    {
        /// <summary> This method will return a signed four digit integer indicating the local
        /// GMT offset. This is the HL7 Offset format in integer representation.
        /// </summary>
        public static int LocalGMTOffset
        {
            get
            {
                int offSet;
                System.Globalization.GregorianCalendar currentTime = new System.Globalization.GregorianCalendar();
                int gmtOffSet = SupportClass.CalendarManager.manager.Get(currentTime, SupportClass.CalendarManager.ZONE_OFFSET);

                int offSetSignInt;
                if (gmtOffSet < 0)
                {
                    offSetSignInt = -1;
                }
                else
                {
                    offSetSignInt = 1;
                }
                //get the absolute value of the gmtOffSet
                int absGmtOffSet = System.Math.Abs(gmtOffSet);
                int gmtOffSetHours = absGmtOffSet / (3600 * 1000);
                int gmtOffSetMin = (absGmtOffSet / 60000) % (60);
                //return the offset value HL7 format
                offSet = ((gmtOffSetHours * 100) + gmtOffSetMin) * offSetSignInt;
                return offSet;
            }


        }

        /// <summary>
        /// Constructor
        /// </summary>
        public DataTypeUtil()
        {
        } //end zero arg constructor


        /// <summary> This method will preappend the zeros to the beginning of num such that the total length
        /// equals totalDigitLength. It will also return the string representation of the new number.
        /// </summary>
        public static System.String preAppendZeroes(int num, int totalDigitLength)
        {
            /* preappend the zeros to the beginning of num such that the total length
            equals totalDigitLength. Return the string representation of the new number*/
            System.String a = System.Convert.ToString(num);
            if (a.Length >= totalDigitLength)
                return a;
            else
            {
                int preAppendAmnt = totalDigitLength - a.Length;
                for (int j = 0; j < preAppendAmnt; j++)
                {
                    a = "0" + a;
                } //end for
                return a;
            } //end else
        }
    } //end class
}