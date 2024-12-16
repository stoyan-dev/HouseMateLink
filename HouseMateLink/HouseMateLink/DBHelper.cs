﻿using System.Data;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HouseMateLink
{
    public class DBHelper
    {
        string connStr = "Server=mssqlstud.fhict.local;Database=dbi550238;User Id=dbi550238;Password=12345; Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadOnly;";

        SqlConnection conn;

        public DBHelper()
        {
            conn = new SqlConnection(connStr);
        }
        public void RemoveUserFromDB(User user)
        {
            try
            {
                string removeUserSql = """
                    DELETE FROM USER
                    WHERE UserID = @id;
                """;
                SqlCommand removeTenantCmd = new SqlCommand(removeUserSql, conn);
                removeTenantCmd.Parameters.AddWithValue("@UserID", user.UserID);
                conn.Open();
                removeTenantCmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            { MessageBox.Show($"RemoveTenantFromDB Error: {ex.Message}"); }
        }


        public List<User> LoadUsersFromDBForAdmin()
        {
            List<User> users = new List<User>();

            try
            {
                string getUserSql = """
                    SELECT Username, Password, Name, Role, RoomNumber, Photo
                    FROM USER
                """;
                SqlCommand getUsers = new SqlCommand(getUserSql, conn);
                conn.Open();
                SqlDataReader dr = getUsers.ExecuteReader();

                while (dr.Read())
                {
                    users.Add(new User(dr["Username"].ToString(), dr["Password"].ToString(), dr["Name"].ToString(), (Role)dr["Role"], (int)dr["RoomNumber"], dr["Photo"].ToString()));
                }

                conn.Close();
                return users;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"GetUsersFromDB Error: {ex}");
                return null;
            }
        }
        public List<User> LoadUsersFromDBForTenant()
        {
            List<User> users = new List<User>();

            try
            {
                string getUserSql = """
                    SELECT Name, Role, RoomNumber, Photo
                    FROM USER
                """;
                SqlCommand getUsers = new SqlCommand(getUserSql, conn);
                conn.Open();
                SqlDataReader dr = getUsers.ExecuteReader();

                while (dr.Read())
                {
                    users.Add(new User(dr["Name"].ToString(), (Role)dr["Role"], (int)dr["RoomNumber"], dr["Photo"].ToString()));
                }

                conn.Close();
                return users;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"GetUsersFromDB Error: {ex}");
                return null;
            }
        }
        public void AddComplaintToDB(Complaint complaint)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string queryAddComplaint = @"insert into COMPLAINT (Description, CreatedAt, isArchived)
                                                  values(@Description, @CreatedAt,@isArchived)";
                    using (SqlCommand addComplaint = new SqlCommand(queryAddComplaint, conn))
                    {
                        addComplaint.Parameters.AddWithValue("@Description", complaint.Description);
                        addComplaint.Parameters.AddWithValue("@CreatedAt", complaint.CreatedAt);
                        addComplaint.Parameters.AddWithValue("@isArchived", complaint.IsArchived ? 1 : 0);

                        addComplaint.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public List<Complaint> LoadUnarchivedComplaints()
        {
            List<Complaint> unarchivedComplaints = new List<Complaint>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string loadComplaints = @"select ComplaintDescription, CreatedAt
                                              from COMPLAINT
                                              where IsArchived = @IsArchived";
                    using (SqlCommand loadComplaint = new SqlCommand(loadComplaints, conn))
                    {
                        loadComplaint.Parameters.AddWithValue("@IsArchived", 1);

                        using (SqlDataReader reader = loadComplaint.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                unarchivedComplaints.Add(new Complaint((int)reader["ComplaintID"], reader["ComplaintDescription"].ToString(), reader.GetDateTime(reader.GetOrdinal("CreatedAt")), reader.GetBoolean(reader.GetOrdinal("IsArchived"))));

                            }
                        }
                    }
                }
                return unarchivedComplaints;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;

            }

        }
        public void ChangeStatusOfComplaint(int complaintID, bool isArchived)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string changeStatus = @"
                UPDATE COMPLAINT 
                SET IsArchived = @IsArchived 
                WHERE ComplaintID = @ComplaintID";

                    using (SqlCommand changeStatusDB = new SqlCommand(changeStatus, conn))
                    {

                        changeStatusDB.Parameters.Add("@IsArchived", SqlDbType.Bit).Value = isArchived;
                        changeStatusDB.Parameters.Add("@ComplaintID", SqlDbType.Int).Value = complaintID;


                        changeStatusDB.ExecuteNonQuery();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        public void AddUser(User user)
        {
            try
            {
                using SqlConnection connection=new SqlConnection(connStr);
                string sql= """ 
                           INSERT INTO [USER] (Username, Password, Name, Role, RoomNumber, Photo)
                           VALUES (@Id, @Username, @Password, @Name, @Role, @RoomNumber, @Photo)
                           """;
                using SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Name", user.Name);
                command.Parameters.AddWithValue("@Role", user.Role);
                command.Parameters.AddWithValue("@RoomNumber", user.RoomNumber);
                command.Parameters.AddWithValue("@Photo", user.Photo);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        public User ValidateUser(User user)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connStr);
                string sql = "SELECT * FROM USER where Username = @Username AND Password = @Password";
                using SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("Password", user.Password);

                using SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        Username = reader.GetString(1),
                        Password = reader.GetString(2),
                        Name = reader.GetString(3),
                        Role = (Role)Enum.Parse(typeof(Role), reader["Role"].ToString()),
                        RoomNumber = reader.GetInt32(5),
                        Photo = reader.GetString(6)
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public void AddAnnouncement(Announcement announcement)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connStr);
                string sql = """ 
                            INSERT INTO ANNOUNCEMENT (Description, CreatedAt, IsArchived)
                            VALUES (@Id, @Description, @Date, @IsArchived)
                            """;
                using SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Description", announcement.Description);
                command.Parameters.AddWithValue("@Date", announcement.CreatedAt);
                command.Parameters.AddWithValue("@IsArchived", announcement.IsArchived);

                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Announcement> LoadUnarchivedAnnouncement()
        {
            List<Announcement> announcements = new List<Announcement>();
            try
            {
                using SqlConnection connection = new SqlConnection(connStr);
                string sql = """
                          SELECT * FROM ANNOUNCEMENT
                          WHERE IsArchived=@IsArchived
                          """;
                using SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@IsArchived", 1);

                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    announcements.Add(new Announcement
                    {
                        AnnouncementID = reader.GetInt32(0),
                        Description = reader.GetString(1),
                        CreatedAt = reader.GetDateTime(2),
                        IsArchived = reader.GetBoolean(3),
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return announcements;
        }

        public void ChangeAnnouncementStatus(int id)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connStr);
                string sql = """
                       UPDATE ANNOUNCEMENT 
                       SET IsArchived=@IsArchived
                       WHERE AnnouncementID=@Id
                       """;
                using SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@IsArchived", 0);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }


}

