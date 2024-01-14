using CSDLNC_05.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace CSDLNC_05.Models
{
    class DB_User
    {
        public static User getUserInfo(String username)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("get_user_info");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@username", username);
                sqlCmd.Connection = new DbConn().conn;
                SqlDataReader res = sqlCmd.ExecuteReader();

                if (res.Read())
                {
                    User user = new User(
                        res.GetInt32(0),
                        res.GetString(1),
                        res.GetString(2),
                        res.GetString(3),
                        res.GetDateTime(4),
                        res.GetString(5),
                        res.GetString(6),
                        res.GetString(7),
                        res.GetBoolean(8),
                        res.GetInt32(9)
                    );
                    return user;
                }
                return null;
            }
            catch(Exception ex)
            {
                Debug.Print(ex.ToString());
                return null;
            }
        }

        public static String getUserRole(int user_id)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand($"SELECT dbo.get_user_role({user_id}) AS ROLE");
               sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.Connection = new DbConn().conn;
                SqlDataReader res = sqlCmd.ExecuteReader();

                if (res.Read())
                {
                    return res["ROLE"].ToString();
                }
                else
                {
                    return "UNKNOWN";
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
                return "UNKNOWN";
            }
        }
        public static List<DentistInfo> listDentistInfos(int branchId)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("list_dentist_infos");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.Parameters.AddWithValue("@branch_id", branchId);
                SqlDataReader res = sqlCmd.ExecuteReader();

                List<DentistInfo> dentistInfos = new List<DentistInfo>();

                while (res.Read())
                {
                    DentistInfo dentist = new DentistInfo(
                        res.GetInt32(0),
                        res.GetString(1)

                    );
                    dentistInfos.Add(dentist);
                }
                return dentistInfos;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
                return null;
            }
        }

        public static string getDetistName (int? dentistID)
        {
            if (dentistID is null) return null;
            try
            {
                SqlCommand sqlCmd = new SqlCommand("get_dentist_name");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.Parameters.AddWithValue("@dentist_id", dentistID);
                SqlDataReader res = sqlCmd.ExecuteReader();

                string dentistName = "";

                while (res.Read())
                {
                    dentistName = res.GetString(0);
                }
                return dentistName;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
                return null;
            }
        }
        public static List<User> getListUserInfoRoleDentist(int branchID)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("get_list_user_role_dentist");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("branch_id", branchID);
                sqlCmd.Connection = new DbConn().conn;
                SqlDataReader res = sqlCmd.ExecuteReader();

                List<User> dentistInfos = new List<User>();

                while (res.Read())
                {
                    User user = new User(
                        res.GetInt32(0),
                        res.GetString(1),
                        res.GetString(2),
                        res.GetString(3),
                        res.GetDateTime(4),
                        res.GetString(5),
                        res.GetString(6),
                        res.GetString(7),
                        res.GetBoolean(8),
                        res.GetInt32(9)
                    );
                    dentistInfos.Add(user);
                }
                return dentistInfos;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
                return null;
            }
        }

        public static List<User> getListUserInfoRoleStaff(int branchID)
        {

            try
            {
                SqlCommand sqlCmd = new SqlCommand("get_list_user_role_staff");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("branch_id", branchID);
                sqlCmd.Connection = new DbConn().conn;
                SqlDataReader res = sqlCmd.ExecuteReader();

                List<User> staffInfos = new List<User>();

                while (res.Read())
                {
                    User user = new User(
                        res.GetInt32(0),
                        res.GetString(1),
                        res.GetString(2),
                        res.GetString(3),
                        res.GetDateTime(4),
                        res.GetString(5),
                        res.GetString(6),
                        res.GetString(7),
                        res.GetBoolean(8),
                        res.GetInt32(9)
                    );
                    staffInfos.Add(user);
                }
                return staffInfos;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
                return null;
            }
        }
        public static int AddDentist(User user, string cert)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("add_dentist");
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@username", user.username);
                sqlCmd.Parameters.AddWithValue("@password", user.password);
                sqlCmd.Parameters.AddWithValue("@full_name", user.full_name);
                sqlCmd.Parameters.AddWithValue("@date_of_birth", user.date_of_birth);
                sqlCmd.Parameters.AddWithValue("@phone_number", user.phone_number);
                sqlCmd.Parameters.AddWithValue("@email", user.email);
                sqlCmd.Parameters.AddWithValue("@permanent_address", user.permanent_address);
                sqlCmd.Parameters.AddWithValue("@gender", user.gender);
                sqlCmd.Parameters.AddWithValue("@working_branch_id",user.working_branch_id);
                sqlCmd.Parameters.AddWithValue("@medical_practice_certificate_code",cert);
                int row_affected = sqlCmd.ExecuteNonQuery();
                return row_affected;
            }
            catch (Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return 0;
            }
        }


        public static int AddStaff(User user)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("add_staff");
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@username", user.username);
                sqlCmd.Parameters.AddWithValue("@password", user.password);
                sqlCmd.Parameters.AddWithValue("@full_name", user.full_name);
                sqlCmd.Parameters.AddWithValue("@date_of_birth", user.date_of_birth);
                sqlCmd.Parameters.AddWithValue("@phone_number", user.phone_number);
                sqlCmd.Parameters.AddWithValue("@email", user.email);
                sqlCmd.Parameters.AddWithValue("@permanent_address", user.permanent_address);
                sqlCmd.Parameters.AddWithValue("@gender", user.gender);
                sqlCmd.Parameters.AddWithValue("@working_branch_id", user.working_branch_id);


                int row_affected = sqlCmd.ExecuteNonQuery();
                return row_affected;
            }
            catch (Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return 0;
            }
        }
        public static int updateDentist(User user)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("update_dentist");
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@dentist_id", user.id);
                sqlCmd.Parameters.AddWithValue("@username", user.username);
                sqlCmd.Parameters.AddWithValue("@password", user.password);
                sqlCmd.Parameters.AddWithValue("@full_name", user.full_name);
                sqlCmd.Parameters.AddWithValue("@date_of_birth", user.date_of_birth);
                sqlCmd.Parameters.AddWithValue("@phone_number", user.phone_number);
                sqlCmd.Parameters.AddWithValue("@email", user.email);
                sqlCmd.Parameters.AddWithValue("@address", user.permanent_address);
                sqlCmd.Parameters.AddWithValue("@gender", user.gender);

                int row_affected = sqlCmd.ExecuteNonQuery();
                return row_affected;
            }
            catch (Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return 0;
            }
        }

        public static int updateStaff(User user)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("update_staff");
                sqlCmd.Connection = new DbConn().conn;
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@staff_id", user.id);
                sqlCmd.Parameters.AddWithValue("@username", user.username);
                sqlCmd.Parameters.AddWithValue("@password", user.password);
                sqlCmd.Parameters.AddWithValue("@full_name", user.full_name);
                sqlCmd.Parameters.AddWithValue("@date_of_birth", user.date_of_birth);
                sqlCmd.Parameters.AddWithValue("@phone_number", user.phone_number);
                sqlCmd.Parameters.AddWithValue("@email", user.email);
                sqlCmd.Parameters.AddWithValue("@address", user.permanent_address);
                sqlCmd.Parameters.AddWithValue("@gender", user.gender);

                int row_affected = sqlCmd.ExecuteNonQuery();
                return row_affected;
            }
            catch (Exception ex)
            {
                Debug.Print($"Error: {ex.ToString()}");
                return 0;
            }
        }
        public static User getUserInfoRoleDentist(int userID)
        {

            try
            {
                SqlCommand sqlCmd = new SqlCommand("get_user_info_role_dentist");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                SqlDataReader res = sqlCmd.ExecuteReader();
                while (res.Read())
                {
                    User user = new User(
                        res.GetInt32(0),
                        res.GetString(1),
                        res.GetString(2),
                        res.GetString(3),
                        res.GetDateTime(4),
                        res.GetString(5),
                        res.GetString(6),
                        res.GetString(7),
                        res.GetBoolean(8),
                        res.GetInt32(9)
                    );
                    return user;
                }
                return null;
              
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
                return null;
            }
        }

        public static User getUserInfoRoleStaff(int userID)
        {

            try
            {
                SqlCommand sqlCmd = new SqlCommand("get_user_info_role_staff");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                SqlDataReader res = sqlCmd.ExecuteReader();
                while (res.Read())
                {
                    User user = new User(
                        res.GetInt32(0),
                        res.GetString(1),
                        res.GetString(2),
                        res.GetString(3),
                        res.GetDateTime(4),
                        res.GetString(5),
                        res.GetString(6),
                        res.GetString(7),
                        res.GetBoolean(8),
                        res.GetInt32(9)
                    );
                    return user;
                }
                return null;

            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
                return null;
            }
        }
        public static List<int> getBranchId()
        {

            try
            {
                SqlCommand sqlCmd = new SqlCommand("get_branch_id");
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Connection = new DbConn().conn;
                SqlDataReader res = sqlCmd.ExecuteReader();
                List<int> list_branch_id = new List<int>();
                while (res.Read())
                {
                    int branch_id = res.GetInt32(0);


                    list_branch_id.Add(branch_id);
                    
                }
                return list_branch_id;

            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
                return null;
            }
        }
    }
}
