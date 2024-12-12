using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace HouseMateLink
{
    public class DBHelper
    {
        string connStr = "Server=mssqlstud.fhict.local;Database=dbi550238;User Id=dbi550238;Password=12345;";
        SqlConnection conn;

        public DBHelper()
        {
            conn = new SqlConnection(connStr);
        }

        public void InitDB()
        {
            //Delete all the data from the tables
            string deleteAllSql = """
                   TRUNCATE TABLE ANNOUNCEMENT;
                   TRUNCATE TABLE COMPLAINT
                   TRUNCATE TABLE EVENT;
                   TRUNCATE TABLE TASK;
                   TRUNCATE TABLE USER;
                """;
            SqlCommand deleteAllCmd = new SqlCommand(deleteAllSql, conn);
            conn.Open();
            deleteAllCmd.ExecuteNonQuery();
            conn.Close();



        }



    }
}
