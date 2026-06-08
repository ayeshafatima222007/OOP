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
    public class ProductDL
    {
        // --- AddProduct ---
        public static bool AddProduct(ProductBL prod)
        {
            if (prod == null)
            {
                return false;
            }

            if (!Validation.IsValidProductId(prod.getProductId()))
            {
                return false;
            }

            if (!Validation.IsValidCategory(prod.getCategory()))
            {
                return false;
            }

            if (!Validation.IsValidName(prod.getName()))
            {
                return false;
            }

            if (!Validation.IsValidColor(prod.getColor()))
            {
                return false;
            }

            if (!Validation.IsValidSize(prod.getSize()))
            {
                return false;
            }

            if (!Validation.IsValidPrice(prod.getPrice()))
            {
                return false;
            }

            if (!Validation.IsValidQuantity(prod.getQuantity()))
            {
                return false;
            }

            if (FindProduct(prod.getProductId()) != null)
            {
                return false;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();

            string query = "INSERT INTO Products (ProductId, Category, Name, Color, Size, Price, Quantity) VALUES(@id, @category, @name, @color, @size, @price, @quantity)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", prod.getProductId());
            cmd.Parameters.AddWithValue("@category", prod.getCategory());
            cmd.Parameters.AddWithValue("@name", prod.getName());
            cmd.Parameters.AddWithValue("@color", prod.getColor());
            cmd.Parameters.AddWithValue("@size", prod.getSize());
            cmd.Parameters.AddWithValue("@price", prod.getPrice());
            cmd.Parameters.AddWithValue("@quantity", prod.getQuantity());
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows > 0;
        }

        // --- FindProduct ---
        public static ProductBL FindProduct(string productId)     //find product by productid
        {
            if (Validation.IsNullOrEmpty(productId))
            {
                return null;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();

            string query = "SELECT * FROM Products WHERE ProductId=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", productId);
            SqlDataReader reader = cmd.ExecuteReader();

            ProductBL prod = null;
            if (reader.Read())
            {
                prod = new ProductBL(
                    reader["ProductId"].ToString(),
                    reader["Category"].ToString(),
                    reader["Name"].ToString(),
                    reader["Color"].ToString(),
                    reader["Size"].ToString(),
                    Convert.ToDouble(reader["Price"]),
                    Convert.ToInt32(reader["Quantity"])
                );
            }
            reader.Close();
            conn.Close();
            return prod;
        }

        // --- FindByCategory ---
        public static List<ProductBL> FindByCategory(string category)      //find product by category
        {
            List<ProductBL> result = new List<ProductBL>();
            if (Validation.IsNullOrEmpty(category))
            {
                return result;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();

            string query = "SELECT * FROM Products WHERE Category=@category";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@category", category);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new ProductBL(
                    reader["ProductId"].ToString(),
                    reader["Category"].ToString(),
                    reader["Name"].ToString(),
                    reader["Color"].ToString(),
                    reader["Size"].ToString(),
                    Convert.ToDouble(reader["Price"]),
                    Convert.ToInt32(reader["Quantity"])
                ));
            }
            reader.Close();
            conn.Close();
            return result;
        }

        // --- GetAllProducts ---
        public static List<ProductBL> GetAllProducts()
        {
            List<ProductBL> result = new List<ProductBL>();

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();

            string query = "SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new ProductBL(
                    reader["ProductId"].ToString(),
                    reader["Category"].ToString(),
                    reader["Name"].ToString(),
                    reader["Color"].ToString(),
                    reader["Size"].ToString(),
                    Convert.ToDouble(reader["Price"]),
                    Convert.ToInt32(reader["Quantity"])
                ));
            }
            reader.Close();
            conn.Close();
            return result;
        }

        // --- RemoveProduct ---
        public static bool RemoveProduct(string productId)
        {
            if (Validation.IsNullOrEmpty(productId)) return false;
            if (FindProduct(productId) == null) return false;

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();

            string query = "DELETE FROM Products WHERE ProductId=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", productId);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows > 0;
        }

        // --- UpdateProduct ---
        public static bool UpdateProduct(string productId, ProductBL updated)
        {
            if (Validation.IsNullOrEmpty(productId))
            {
                return false;
            }
            if (updated == null)
            {
                return false;
            }
            if (FindProduct(productId) == null)
            {
                return false;
            }

            if (!Validation.IsValidCategory(updated.getCategory()))
            {
                return false;
            }

            if (!Validation.IsValidName(updated.getName()))
            {
                return false;
            }

            if (!Validation.IsValidColor(updated.getColor()))
            {
                return false;
            }

            if (!Validation.IsValidSize(updated.getSize()))
            {
                return false;
            }

            if (!Validation.IsValidPrice(updated.getPrice()))
            {
                return false;
            }

            if (!Validation.IsValidQuantity(updated.getQuantity()))
            {
                return false;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();

            string query = "UPDATE Products SET Category=@category, Name=@name, Color=@color, Size=@size, Price=@price, Quantity=@quantity WHERE ProductId=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", productId);
            cmd.Parameters.AddWithValue("@category", updated.getCategory());
            cmd.Parameters.AddWithValue("@name", updated.getName());
            cmd.Parameters.AddWithValue("@color", updated.getColor());
            cmd.Parameters.AddWithValue("@size", updated.getSize());
            cmd.Parameters.AddWithValue("@price", updated.getPrice());
            cmd.Parameters.AddWithValue("@quantity", updated.getQuantity());
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows > 0;
        }
    }
}
