using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDLNC_05.Models;
using CSDLNC_05.View.Login;

namespace CSDLNC_05.Controllers
{
    class User
    {
        public int id { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public String full_name { get; set; }
        public DateTime date_of_birth { get; set; }
        public String phone_number { get; set; }
        public String email { get; set; }
        public String permanent_address { get; set; }
        public Boolean gender { get; set; }
        public int working_branch_id { get; set; }

        public User(int id, string username, string password, string full_name, DateTime date_of_birth, string phone_number, string email, string permanent_address, bool gender, int working_branch_id)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.full_name = full_name;
            this.date_of_birth = date_of_birth;
            this.phone_number = phone_number;
            this.email = email;
            this.permanent_address = permanent_address;
            this.gender = gender;
            this.working_branch_id = working_branch_id;
        }

        public static int login(String username, String password)
        {
            User user = DB_User.getUserInfo(username);

            if (user == null)
            {
                return 0;
            }

            if (password == user.password)
            {
                Program.currentUserId = user.id;
                Program.currentUserName = user.full_name;
                Program.workingBranchId = user.working_branch_id;

                if (!User.getUserRole(user.id))
                {
                    return 2;
                }

                return 1;
            }
            return 0;
        }

        public static bool getUserRole(int user_id)
        {
            String role = DB_User.getUserRole(user_id);
            
            if(role == "UNKNOWN")
            {
                return false;
            }
            else
            {
                Program.currentUserRole = role;
                return true;
            }
        }

        public static string getDetistName(int? dentistID)
        {
            return DB_User.getDetistName(dentistID);
        }

        public static List<User> getListUserInfoRoleDentist(int branchID)
        {
            return DB_User.getListUserInfoRoleDentist(branchID);
        }

        public static List<User> getListUserInfoRoleStaff(int branchID)
        {
            return DB_User.getListUserInfoRoleStaff(branchID);
        }
        public static bool AddDentist(User user, string cert)
        {
            return DB_User.AddDentist(user, cert) == 2;
        }
        public static bool AddStaff(User user)
        {
           return DB_User.AddStaff(user) == 2;
        }
        public static bool updateDentist(User user)
        {
            return DB_User.updateDentist(user)==1;
        }

        public static bool updateStaff(User user) { 
            return DB_User.updateStaff(user)==1;
        }
        public static User getUserInfoRoleDentist(int userID)
        {
            return DB_User.getUserInfoRoleDentist(userID);
        }
        public static User getUserInfoRoleStaff(int userID) { 
            return DB_User.getUserInfoRoleStaff(userID);
        }
        public static List<int> getBranchId()
        {
            return DB_User.getBranchId();
        }
    }

}
