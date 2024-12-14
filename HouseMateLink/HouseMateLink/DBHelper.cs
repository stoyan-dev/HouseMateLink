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
            try
            {
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
            catch(Exception ex)
            { MessageBox.Show($"InitDB Error: {ex}"); }
        }

        public void AddTenantToDB(User u)
        {
            //Add tenant to database
            try
            {
                string addTenantSql = """
                    INSERT INTO USER (Username, Password, Name, IsAdmin, RoomNumber)
                    VALUES(@username, @password, @name, 0, @roomnr);
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
            catch(Exception ex)
            { MessageBox.Show($"AddTenantToDB Error: {ex}"); }
        }

        public void RemoveTenantFromDB(User u)
        {
            //Remove tenant from database
            try
            {
                string removeTenantSql = """
                    DELETE FROM USER
                    WHERE UserID = @id;
                """;
                SqlCommand removeTenantCmd = new SqlCommand(removeTenantSql, conn);
                removeTenantCmd.Parameters.AddWithValue("id", u.UserID);
                conn.Open();
                removeTenantCmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            { MessageBox.Show($"RemoveTenantFromDB Error: {ex}"); }
        }

        public void AddAdminToDB(User u)
        {
            //Add admin to database
            try
            {
                string addAdminSql = """
                    INSERT INTO USER (Username, Password, Name, IsAdmin, RoomNumber)
                    VALUES(@username, @password, @name, 1, 0);
                """;
                SqlCommand addAdminCmd = new SqlCommand(addAdminSql, conn);
                addAdminCmd.Parameters.AddWithValue("username", u.Username);
                addAdminCmd.Parameters.AddWithValue("password", u.Password);
                addAdminCmd.Parameters.AddWithValue("name", u.Name);
                conn.Open();
                addAdminCmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            { MessageBox.Show($"AddAdminToDB Error: {ex}"); }
        }

        public void RemoveAdminFromDB(User u)
        {
            //Remove admin from database
            try
            {
                string removeAdminSql = """
                    DELETE FROM USER
                    WHERE UserID = @id;
                """;
                SqlCommand removeAdminCmd = new SqlCommand(removeAdminSql, conn);
                removeAdminCmd.Parameters.AddWithValue("id", u.UserID);
                conn.Open();
                removeAdminCmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            { MessageBox.Show($"RemoveTenantFromDB Error: {ex}"); }
        }

        public List<User>? GetUsersFromDB()
        {
            //Get the info of all users from the database
            try
            {
                string getUserSql = """
                    SELECT Username, Password, Name, IsAdmin, RoomNumber
                    FROM USER
                """;
                SqlCommand getUserCmd = new SqlCommand(getUserSql, conn);
                conn.Open();
                SqlDataReader dr = getUserCmd.ExecuteReader();

                List<User> users = new List<User>();
                while (dr.Read())
                {
                    Role role = (Role)Convert.ToInt32(dr[3]);
                    users.Add(new User(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), role, Convert.ToInt32(dr[4])));
                }

                conn.Close();
                return users;
            }
            catch(Exception ex)
            { 
                MessageBox.Show($"GetUsersFromDB Error: {ex}");
                return null;
            }
        }





    }
}
