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

        public void Init_db()
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

            //Add only the admin account
            string addAdminSql = """
                    INSERT INTO USER (Username, Password, Name, IsAdmin, RoomNumber) 
                    VALUES('admin', 'admin123','Robert', 1, 0);
                """;
            SqlCommand addAdminCmd = new SqlCommand(addAdminSql, conn);
            conn.Open();
            addAdminCmd.ExecuteNonQuery();
            conn.Close();
        }

        public void AddTenantToDB(User u)
        {
            string addTenantSql = """
                    INSERT INTO USER (Username, Password, Name, IsAdmin, RoomNumber)
                    VALUES(@username, @password, @name, 0, @roomnr)
                """;
            SqlCommand addTenantCmd = new SqlCommand(addTenantSql, conn);
            addTenantCmd.Parameters.AddWithValue("username", u.Username);
            addTenantCmd.Parameters.AddWithValue("password", u.Password);
            addTenantCmd.Parameters.AddWithValue("name", u.Name);
            addTenantCmd.Parameters.AddWithValue("roomnr", u.RoomNumber);
            conn.Open();
            addTenantCmd.ExecuteNonQuery();
            conn.Close();

        }



    }
}
