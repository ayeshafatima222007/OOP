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
    public class DiscountDL
    {
        

        // --- AddDiscount ---
        public static bool AddDiscount(DiscountBL d)
        {
            if (d == null)
            {
                return false;
            }

            if (!Validation.IsValidDiscountCode(d.getDiscountCode()))
            {
                return false;
            }

            if (!Validation.IsValidDiscountPercent(d.getDiscountPercent()))
            {
                return false;
            }

            if (FindDiscount(d.getDiscountCode()) != null)
            {
                return false;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();

            string query = "INSERT INTO Discounts (DiscountCode, DiscountPercent, IsActive) VALUES(@code, @percent, @active)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@code", d.getDiscountCode());
            cmd.Parameters.AddWithValue("@percent", d.getDiscountPercent());
            cmd.Parameters.AddWithValue("@active", d.getIsActive());
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows > 0;
        }

        // --- FindDiscount ---
        public static DiscountBL FindDiscount(string code)
        {
            if (Validation.IsNullOrEmpty(code))
            {
                return null;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "SELECT * FROM Discounts WHERE DiscountCode=@code";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@code", code);
            SqlDataReader reader = cmd.ExecuteReader();

            DiscountBL d = null;
            if (reader.Read())
            {
                d = new DiscountBL(
                    reader["DiscountCode"].ToString(),
                    Convert.ToDouble(reader["DiscountPercent"]),
                    Convert.ToBoolean(reader["IsActive"])
                );
            }
            reader.Close();
            conn.Close();
            return d;
        }

        // --- GetAllDiscounts ---
        public static List<DiscountBL> GetAllDiscounts()
        {
            List<DiscountBL> result = new List<DiscountBL>();

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Discounts", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new DiscountBL(
                    reader["DiscountCode"].ToString(),
                    Convert.ToDouble(reader["DiscountPercent"]),
                    Convert.ToBoolean(reader["IsActive"])
                ));
            }
            reader.Close();
            conn.Close();
            return result;
        }

        // --- UpdateDiscount ---
        public static bool UpdateDiscount(string code, DiscountBL updated)
        {
            if (Validation.IsNullOrEmpty(code))
            {
                return false;
            }

            if (updated == null)
            {
                return false;
            }

            if (FindDiscount(code) == null)
            {
                return false;
            }

            if (!Validation.IsValidDiscountPercent(updated.getDiscountPercent()))
            {
                return false;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "UPDATE Discounts SET DiscountPercent=@percent, IsActive=@active WHERE DiscountCode=@code";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@percent", updated.getDiscountPercent());
            cmd.Parameters.AddWithValue("@active", updated.getIsActive());
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows > 0;
        }

        // --- RemoveDiscount ---
        public static bool RemoveDiscount(string code)
        {
            if (Validation.IsNullOrEmpty(code)) return false;
            if (FindDiscount(code) == null) return false;

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "DELETE FROM Discounts WHERE DiscountCode=@code";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@code", code);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows > 0;
        }
    }
}
