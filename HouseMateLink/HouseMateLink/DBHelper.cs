﻿using System.Data;
using Microsoft.Data.SqlClient;

namespace HouseMateLink
{
    public class DBHelper
    {
        string connStr = "Server=mssqlstud.fhict.local;Database=dbi550238;User Id=dbi550238;Password=12345; Encrypt=True;TrustServerCertificate=True;";

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
                    update [USER]
                    set RoomNumber = @RoomNumber
                    where Username = @Username
                """;
                SqlCommand removeTenantCmd = new SqlCommand(removeUserSql, conn);
                removeTenantCmd.Parameters.AddWithValue("@RoomNumber", 0);
                removeTenantCmd.Parameters.AddWithValue("@Username", user.Username);
                conn.Open();
                removeTenantCmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            { MessageBox.Show($"RemoveTenantFromDB Error: {ex.Message}"); }
        }


        public List<User>? LoadUsersFromDBForAdmin()
        {
            List<User> users = new List<User>();

            try
            {
                string getUserSql = """
                    SELECT Username, [Password], [Name], [Role], RoomNumber, Photo
                    FROM [USER]
                    where RoomNumber <> 0 or [Role]='ADMIN'
                """;
                SqlCommand getUsers = new SqlCommand(getUserSql, conn);
                conn.Open();
                SqlDataReader dr = getUsers.ExecuteReader();

                while (dr.Read())
                {
                    users.Add(new User(dr["Username"].ToString(), dr["Password"].ToString(), dr["Name"].ToString(), Enum.Parse<Role>(dr["Role"].ToString()), (int)dr["RoomNumber"], dr["Photo"].ToString()));
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
        public List<User>? LoadUsersFromDBForTenant()
        {
            List<User> users = new List<User>();

            try
            {
                string getUserSql = """
                    SELECT [Name], [Role], RoomNumber, Photo
                    FROM [USER]
                    where RoomNumber <> 0 or [Role]='ADMIN'
                """;
                SqlCommand getUsers = new SqlCommand(getUserSql, conn);
                conn.Open();
                SqlDataReader dr = getUsers.ExecuteReader();

                while (dr.Read())
                {
                    users.Add(new User(dr["Name"].ToString(), Enum.Parse<Role>(dr["Role"].ToString()), (int)dr["RoomNumber"], dr["Photo"].ToString()));
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
        public List<User>? LoadTenants()
        {
            List<User> users = new List<User>();

            try
            {
                string getUserSql = """
                    SELECT [Name], [Role], RoomNumber, Photo
                    FROM [USER]
                    where RoomNumber <> 0 and Role = 'TENANT'
                """;
                SqlCommand getUsers = new SqlCommand(getUserSql, conn);
                conn.Open();
                SqlDataReader dr = getUsers.ExecuteReader();

                while (dr.Read())
                {
                    users.Add(new User(dr["Name"].ToString(), Enum.Parse<Role>(dr["Role"].ToString()), (int)dr["RoomNumber"], dr["Photo"].ToString()));
                }

                conn.Close();
                return users;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"GetTenantsFromDB Error: {ex}");
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
                        addComplaint.Parameters.AddWithValue("@isArchived", complaint.IsArchived);

                        addComplaint.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public List<Complaint>? LoadUnarchivedComplaints()
        {
            List<Complaint> unarchivedComplaints = new List<Complaint>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string loadComplaints = @"select ComplaintID ,Description, CreatedAt
                                              from COMPLAINT
                                              where IsArchived = @IsArchived";
                    using (SqlCommand loadComplaint = new SqlCommand(loadComplaints, conn))
                    {
                        loadComplaint.Parameters.AddWithValue("@IsArchived", false);

                        using (SqlDataReader reader = loadComplaint.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                unarchivedComplaints.Add(new Complaint((int)reader["ComplaintID"] ,reader["Description"].ToString(), reader.GetDateTime(reader.GetOrdinal("CreatedAt"))));

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
        public void ChangeStatusOfComplaint(int complaintID /* bool isArchived*/)
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

                        // changeStatusDB.Parameters.Add("@IsArchived", SqlDbType.Bit).Value = isArchived;
                        changeStatusDB.Parameters.AddWithValue("@IsArchived", true);
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
                using SqlConnection connection = new SqlConnection(connStr);
                string sql = """ 
                           INSERT INTO [USER] (Username, [Password], [Name], [Role], RoomNumber, Photo)
                           VALUES (@Username, @Password, @Name, @Role, @RoomNumber, @Photo)
                           """;
                using SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Name", user.Name);
                command.Parameters.AddWithValue("@Role", user.Role.ToString());
                command.Parameters.AddWithValue("@RoomNumber", user.RoomNumber);
                command.Parameters.AddWithValue("@Photo", user.Photo);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public User? ValidateUser(string username, string password)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connStr);
                string sql = "SELECT Username, [Password], [Name], [Role], RoomNumber, Photo FROM [USER] WHERE Username = @Username AND [Password] = @Password";

                using SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var roleValue = reader["Role"]?.ToString();
                    Role role = Role.TENANT;
                    if (!string.IsNullOrEmpty(roleValue))
                    {
                        role = Enum.TryParse(roleValue, out Role parsedRole) ? parsedRole : Role.TENANT;
                    }

                    return new User
                    {
                        Username = reader["Username"]?.ToString() ?? string.Empty,
                        Password = reader["Password"]?.ToString() ?? string.Empty,
                        Name = reader["Name"]?.ToString() ?? string.Empty,
                        Role = role,
                        RoomNumber = reader["RoomNumber"] != DBNull.Value ? Convert.ToInt32(reader["RoomNumber"]) : 0,
                        Photo = reader["Photo"] != DBNull.Value ? reader["Photo"].ToString() : string.Empty
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void AddAnnouncement(Announcement announcement)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connStr);
                string sql = """ 
                            INSERT INTO ANNOUNCEMENT (Username, Description, CreatedAt, IsArchived)
                            VALUES (@username, @Description, @Date, @IsArchived)
                            """;
                using SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Username", announcement.Username);
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
                string sql = @"SELECT AnnouncementID, Username, Description, CreatedAt
                       FROM ANNOUNCEMENT
                       WHERE IsArchived = @IsArchived";

                using SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@IsArchived", false);

                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    announcements.Add(new Announcement(
                        (int)reader["AnnouncementID"],
                        reader["Username"].ToString(),
                        reader["Description"].ToString(),
                        reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                    ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading announcements: {ex.Message}");
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
                command.Parameters.Add("@IsArchived", SqlDbType.Bit).Value = true;  
                command.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("No rows were updated. Please check the AnnouncementID.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void AddTaskToDB(Task t)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connStr);
                string sql = """ 
                            INSERT INTO TASK (Username,TaskDate, TaskType)
                            VALUES (@username, @taskdate, @tasktype)
                            """;
                using SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@username", t.Username);
                command.Parameters.AddWithValue("@taskdate", t.TaskDate);
                command.Parameters.AddWithValue("@tasktype", t.TaskType.ToString());

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("No rows were updated. Please check the TaskID.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<Task> LoadTasksFromDB()
        {
            List<Task> tasks = new List<Task>();
            try
            {
                using SqlConnection connection = new SqlConnection(connStr);
                string sql = @"SELECT Username, TaskDate, TaskType FROM TASK";

                using SqlCommand command = new SqlCommand(sql, connection);

                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tasks.Add(new Task(
                        reader["Username"].ToString(),
                        Convert.ToDateTime(reader["TaskDate"]),
                        (TaskTypeEnum)reader["TaskType"])
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tasks: {ex.Message}");
            }
            return tasks;
        }

    }


}

