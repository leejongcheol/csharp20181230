using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System.Collections;

namespace AddrBook
{
   
    public class Common_DB
    {
        //-----------------------------------------------------------------------------
        // DataBase Connection
        //-----------------------------------------------------------------------------
        public static OleDbConnection DBConnection()
        {
            OleDbConnection Conn;
            //아래는 오라클용 접속 문자열, data source 애는 tnsnames.ora 파일에 있는 Alias명을 넣으면 됩니다.
            //32비트 
            //string ConStr = "Provider=MSDAORA;data source=onj;User ID=scott;Password=tiger";
            //64비트
            string ConStr = "Provider=OraOLEDB.Oracle;data source=topcredu;User ID=scott;Password=tiger";

            //MS-SQL OLEDB 방식
            // string ConStr = @"Provider=SQLOLEDB;Data Source=localhost\OJC;Initial Catalog=test;Integrated Security=SSPI";


            Conn = new OleDbConnection(ConStr);
            return Conn;
        }


        //-----------------------------------------------------------------------------
        // DataSelect 
        //-----------------------------------------------------------------------------
        public static OleDbDataReader DataSelect(string sql, OleDbConnection Conn)
        {
            try
            {
                OleDbCommand myCommand = new OleDbCommand(sql, Conn);
                return myCommand.ExecuteReader();   
            }
            catch (Exception ex)
            {
                //Log File에 출력 

                MessageBox.Show(sql + "\n" + ex.Message, "DataSelect");
                return null;
            }
            finally
            {
            }
        }


        //-----------------------------------------------------------------------------
        // DataDelete, DataInsert 
        //-----------------------------------------------------------------------------
        public static bool DataManupulation(string sql, OleDbConnection Conn)
        {
            try
            {
                OleDbCommand myCommand = new OleDbCommand(sql, Conn);
                myCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //Log File에 출력 

                MessageBox.Show(sql + "\n" + ex.Message, "DataManupulation");
                return false;
            }
            finally
            {

            }
        }
    }
 


}
