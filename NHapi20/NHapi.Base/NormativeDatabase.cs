/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "NormativeDatabase.java".  Description: 
/// "Point of access to a copy of the HL7 normative database" 
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
using System.Data;
using NHapi.Base.Log;

namespace NHapi.Base
{

    /// <summary> <p>Point of access to a copy of the HL7 normative database.  A typical way of 
    /// obtaining and using a database connection would be ...</p>
    /// <p><code>Connection c = NormativeDatabase.getInstance().getConnection();<br>
    /// // ... use the database ... <br>
    /// NormativeDatabase.returnConnection(c);</code></p>
    /// <p>Since the database may be installed differently on different systems, certain system
    /// properties must be set with the required connection information, as follows: </p>
    /// <p><code>ca.on.uhn.hl7.database.url</code> - the URL of the JDBC connection<br>
    /// <code>ca.on.uhn.hl7.database.user</code> - the user ID needed to connect (if required)<br>
    /// <code>ca.on.uhn.hl7.database.passsword</code> - the password associated with the above user 
    /// (if required)</p>
    /// <p>The required JDBC driver must also be loaded (this can be done by ensuring that the 
    /// required driver appears in the classpath and appending the class name to the 
    /// "jdbc.drivers" system property.  
    /// </summary>
    /// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
    /// </author>
    public class NormativeDatabase
    {
        /// <summary> Returns the singleton instance of NormativeDatabase.  </summary>
        private System.Data.OleDb.OleDbConnection _conn;
        public static NormativeDatabase Instance
        {
            get
            {
                lock (typeof(NHapi.Base.NormativeDatabase))
                {
                    if (db == null)
                    {
                        db = new NormativeDatabase();
                    }
                    return db;
                }
            }

        }
        /// <summary> Provides a Connection to the normative database. 
        /// A new connection may be created if none are available.
        /// </summary>
        virtual public System.Data.OleDb.OleDbConnection Connection
        {
            get
            {
                lock (this)
                {
                    try
                    {
                        if (_conn.State != ConnectionState.Open)
                            _conn.Open();
                    }
                    catch (Exception)
                    {
                        _conn = new System.Data.OleDb.OleDbConnection(_connectionString);
                        _conn.Open();
                    }
                    return _conn;
                }
            }

        }

        public void OpenNewConnection(string conn)
        {
            lock (this)
            {
                _connectionString = conn;
                if (_conn.State == ConnectionState.Open)
                    _conn.Close();
                _conn.ConnectionString = conn;
                _conn.Open();
            }

        }

        private static readonly IHapiLog log;

        private static NormativeDatabase db = null;
        private string _connectionString;

        /// <summary> Private constructor ... checks system properties for connection 
        /// information
        /// </summary>
        private NormativeDatabase()
        {
            _connectionString = ConfigurationSettings.ConnectionString;
            _conn = new System.Data.OleDb.OleDbConnection(_connectionString);
            _conn.Open();
        }

        /// <summary> Used to return an HL7 normative database connection to the connection pool.  If the
        /// given connection is not in fact a connection to the normative database, it is
        /// discarded. 
        /// </summary>
        public virtual void returnConnection(System.Data.OleDb.OleDbConnection conn)
        {
            //check if this is a normative DB connection 
            _conn.Close();
        }

        //test
        [STAThread]
        public static void Main(System.String[] args)
        {
            try
            {
                System.Data.OleDb.OleDbConnection conn = NormativeDatabase.Instance.Connection;
                System.Data.OleDb.OleDbCommand stmt = SupportClass.TransactionManager.manager.CreateStatement(conn);
                System.Data.OleDb.OleDbCommand temp_OleDbCommand;
                temp_OleDbCommand = stmt;
                temp_OleDbCommand.CommandText = "select * from TableValues";
                System.Data.OleDb.OleDbDataReader rs = temp_OleDbCommand.ExecuteReader();
                while (rs.Read())
                {
                    System.Object tabNum = rs.GetValue(1 - 1);
                    System.Object val = rs.GetValue(3 - 1);
                    System.Object desc = rs.GetValue(4 - 1);
                    System.Console.Out.WriteLine("Table: " + tabNum + " Value: " + val + " Description: " + desc);
                }
            }
            catch (System.Data.OleDb.OleDbException e)
            {
                log.Error("test msg!!", e);
            }
            catch (System.Exception e)
            {
                log.Error("test msg!!", e);
            }
        }
        static NormativeDatabase()
        {
            log = HapiLogFactory.GetHapiLog(typeof(NormativeDatabase));
        }
    }
}