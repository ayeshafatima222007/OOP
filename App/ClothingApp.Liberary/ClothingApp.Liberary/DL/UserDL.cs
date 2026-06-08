using ClothingApp.Library.BL;
using ClothingApp.Library.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingApp.Library.DL
{
    public class UserDL : IUserDL
    {
        // --- SignUp ---
        public bool SignUp(UserBL user)
        {
            if (user == null) return false;
            if (!Validation.IsValidUsername(user.getUsername())) return false;
            if (!Validation.IsValidPassword(user.getPassword())) return false;
            if (!Validation.IsValidPhone(user.getPhoneNumber())) return false;
            if (FindByUsername(user.getUsername()) != null) return false;  // duplicate check BEFORE opening connection

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "INSERT INTO Users (Username, Password, PhoneNumber, Role) VALUES(@username, @password, @phone, @role)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", user.getUsername());
            cmd.Parameters.AddWithValue("@password", user.getPassword());
            cmd.Parameters.AddWithValue("@phone", user.getPhoneNumber());
            cmd.Parameters.AddWithValue("@role", user.getRole());
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows > 0;
        }

        // --- SignIn ---
        public UserBL SignIn(string username, string password)
        {
            if (!Validation.IsValidUsername(username)) return null;
            if (!Validation.IsValidPassword(password)) return null;

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "SELECT * FROM Users WHERE Username=@username AND Password=@password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = cmd.ExecuteReader();

            UserBL user = null;
            if (reader.Read())
            {
                user = CreateUser(reader);   // using helper instead of new UserBL()
            }
            reader.Close();                  // close reader before connection
            conn.Close();
            return user;
        }

        // --- FindByUsername ---
        public UserBL FindByUsername(string username)
        {
            if (Validation.IsNullOrEmpty(username)) return null;

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "SELECT * FROM Users WHERE Username=@username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = cmd.ExecuteReader();

            UserBL user = null;
            if (reader.Read())
            {
                user = CreateUser(reader);   // using helper instead of new UserBL()
            }
            reader.Close();                  // close reader before connection
            conn.Close();
            return user;
        }

        // --- FindByRole ---
        public List<UserBL> FindByRole(string role)
        {
            List<UserBL> result = new List<UserBL>();
            if (Validation.IsNullOrEmpty(role)) return result;

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "SELECT * FROM Users WHERE Role=@role";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@role", role);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Add(CreateUser(reader));  // using helper instead of new UserBL()
            }
            reader.Close();                      // close reader before connection
            conn.Close();
            return result;
        }

        // --- RemoveUser ---
        public bool RemoveUser(string username)
        {
            if (Validation.IsNullOrEmpty(username))
            {
                return false;
            }

            if (FindByUsername(username) == null)
            {
                return false;
            } 

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "DELETE FROM Users WHERE Username=@username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows > 0;
        }

        // --- Helper: CreateUser ---
        private UserBL CreateUser(SqlDataReader reader)
        {
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();
            string phone = reader["PhoneNumber"].ToString();
            string role = reader["Role"].ToString();

            if (role == "Buyer")
            {
                return new BuyerBL(username, password, phone, "");  // address not stored in Users table
            }

            else if (role == "Seller")
            {
                return new SellerBL(username, password, phone);
            }

            else if (role == "Admin")
            {
                return new AdminBL(username, password, phone);
            }

            else
            {
                return null;
            }
        }


        // --- UpdateUser ---
        public bool UpdateUser(string username, string newPhone, string newPassword, string newAddress = "")
        {
            if (Validation.IsNullOrEmpty(username)) return false;
            if (FindByUsername(username) == null) return false;
            if (!Validation.IsValidPhone(newPhone)) return false;
            if (!Validation.IsValidPassword(newPassword)) return false;

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "UPDATE Users SET PhoneNumber=@phone, Password=@password, Address=@address WHERE Username=@username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@phone", newPhone);
            cmd.Parameters.AddWithValue("@password", newPassword);
            cmd.Parameters.AddWithValue("@address", newAddress);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows > 0;
        }
    }
}