using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * This file contains the database operations on a 'MS Access' database file
 * Only 'sem1r' table is used for testing
 * 
 * Reference: https://www.codeproject.com/Tips/858771/MS-Access-mdb-plus-Csharp-SELECT-INSERT-DELETE-and
 */
using System.Data.OleDb;

namespace ConsoleApplication1
{
    class db2
    {
        private OleDbConnection conn = null;
        private OleDbDataReader reader = null;

        public db2()
        {
            Console.WriteLine("Constructor 1 started");
        }

        
        public db2(int x)
        {
            Console.WriteLine("Constructor 2 started");
            Connect();
            readDB("select * from sem1r");
        }

        private bool readDB(string sqlcmd)
        {
            bool op_result = false;
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(sqlcmd, conn)  )
            {
                try
                {
                    Console.WriteLine(adapter.ToString());
                    Console.WriteLine(adapter.GetFillParameters());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return op_result;
        }

        private void Connect()
        {
            //OleDbConnection conn = null;
            //OleDbDataReader reader = null;
            try
            {
                conn = new OleDbConnection(
                    "Provider=Microsoft.Jet.OLEDB.4.0; " +
                    "Data Source=" + "../../../../sem1r.mdb");
                conn.Open();

                //OleDbCommand cmd = new OleDbCommand("Select * FROM sem1r", conn);
                //reader = cmd.ExecuteReader();

                //datagrid.DataSource = reader;
                //datagrid.DataBind();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            //  Response.Write(e.Message);
            //  Response.End();
            }
            /*finally
            {
                if (reader != null) reader.Close();
                if (conn != null) conn.Close();
            }*/
        } //end of connect()___________________________________

    }
}
