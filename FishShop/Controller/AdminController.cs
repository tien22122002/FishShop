using FishShop.model;
using FishShop.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishShop.Controller
{
    internal class AdminController
    {
        admin admin;
        public AdminController()
        {
            admin = new admin();
        }
        public bool CheckLogin(admin admin)
        {
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();
                string query = "SELECT Count(*) FROM ADMIN WHERE UserAdmin = @user AND PassAdmin = @pass";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@user", admin.getUserAdmin());
                    command.Parameters.AddWithValue("@pass", admin.getPassword());
                    int rowCount = (int)command.ExecuteScalar();
                    return rowCount > 0;
                }
            }
        }

        public bool ChangePassword(admin admin, string newPassword)
        {
            using (SqlConnection conn = DatabaseHelper.getConnection())
            {
                conn.Open();
                string query = "UPDATE ADMIN SET PassAdmin = @newPassword WHERE UserAdmin = @user AND PassAdmin = @oldPassword";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@newPassword", newPassword);
                    command.Parameters.AddWithValue("@user", admin.getUserAdmin());
                    command.Parameters.AddWithValue("@oldPassword", admin.getPassword());
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

    }
}
