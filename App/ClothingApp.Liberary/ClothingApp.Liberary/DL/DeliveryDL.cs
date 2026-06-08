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
    public class DeliveryDL
    {
        // --- GetDeliveryCount ---
        public static int GetDeliveryCount()     //For delivery Id
        {
            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Deliveries", conn);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count;
        }


        // --- AddDelivery ---
        public static bool AddDelivery(DeliveryBL delivery)
        {
            if (delivery == null)
            {
                return false;
            }

            if (Validation.IsNullOrEmpty(delivery.getDeliveryId()))
            {
                return false;
            }

            if (Validation.IsNullOrEmpty(delivery.getOrderId()))
            {
                return false;
            }

            if (!Validation.IsValidDeliveryMethod(delivery.getDeliveryMethod()))
            {
                return false;
            }

            if (!Validation.IsValidAddress(delivery.getDeliveryAddress()))
            {
                return false;
            }

            if (FindDelivery(delivery.getDeliveryId()) != null)
            {
                return false;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "INSERT INTO Deliveries (DeliveryId, OrderId, DeliveryMethod, DeliveryAddress, DeliveryCost, DeliveryStatus) VALUES(@id, @orderId, @method, @address, @cost, @status)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", delivery.getDeliveryId());
            cmd.Parameters.AddWithValue("@orderId", delivery.getOrderId());
            cmd.Parameters.AddWithValue("@method", delivery.getDeliveryMethod());
            cmd.Parameters.AddWithValue("@address", delivery.getDeliveryAddress());
            cmd.Parameters.AddWithValue("@cost", delivery.getDeliveryCost());
            cmd.Parameters.AddWithValue("@status", delivery.getDeliveryStatus());
            int rows = cmd.ExecuteNonQuery();

            conn.Close();
            return rows > 0;
        }

        // --- FindDelivery ---
        public static DeliveryBL FindDelivery(string deliveryId)
        {
            if (Validation.IsNullOrEmpty(deliveryId))
            {
                return null;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();

            string query = "SELECT * FROM Deliveries WHERE DeliveryId=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", deliveryId);
            SqlDataReader reader = cmd.ExecuteReader();

            DeliveryBL delivery = null;
            if (reader.Read())
            {
                delivery = new DeliveryBL(
                    reader["DeliveryId"].ToString(),
                    reader["OrderId"].ToString(),
                    reader["DeliveryMethod"].ToString(),
                    reader["DeliveryAddress"].ToString(),
                    Convert.ToDouble(reader["DeliveryCost"])
                );
                delivery.setDeliveryStatus(reader["DeliveryStatus"].ToString());
            }
            reader.Close();
            conn.Close();
            return delivery;
        }

        // --- FindByOrder ---
        public static DeliveryBL FindByOrder(string orderId)
        {
            if (Validation.IsNullOrEmpty(orderId))
            {
                return null;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "SELECT * FROM Deliveries WHERE OrderId=@orderId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@orderId", orderId);
            SqlDataReader reader = cmd.ExecuteReader();

            DeliveryBL delivery = null;
            if (reader.Read())
            {
                delivery = new DeliveryBL(
                    reader["DeliveryId"].ToString(),
                    reader["OrderId"].ToString(),
                    reader["DeliveryMethod"].ToString(),
                    reader["DeliveryAddress"].ToString(),
                    Convert.ToDouble(reader["DeliveryCost"])
                );
                delivery.setDeliveryStatus(reader["DeliveryStatus"].ToString());
            }
            reader.Close();
            conn.Close();
            return delivery;
        }

        // --- GetAllDeliveries ---
        public static List<DeliveryBL> GetAllDeliveries()
        {
            List<DeliveryBL> result = new List<DeliveryBL>();

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Deliveries", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DeliveryBL delivery = new DeliveryBL(
                    reader["DeliveryId"].ToString(),
                    reader["OrderId"].ToString(),
                    reader["DeliveryMethod"].ToString(),
                    reader["DeliveryAddress"].ToString(),
                    Convert.ToDouble(reader["DeliveryCost"])
                );
                delivery.setDeliveryStatus(reader["DeliveryStatus"].ToString());
                result.Add(delivery);
            }
            reader.Close();
            conn.Close();
            return result;
        }

        // --- UpdateStatus ---
        public static bool UpdateStatus(string deliveryId, string newStatus)
        {
            if (Validation.IsNullOrEmpty(deliveryId))
            {
                return false;
            }

            if (Validation.IsNullOrEmpty(newStatus))
            {
                return false;
            }

            if (FindDelivery(deliveryId) == null)
            {
                return false;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "UPDATE Deliveries SET DeliveryStatus=@status WHERE DeliveryId=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", deliveryId);
            cmd.Parameters.AddWithValue("@status", newStatus);
            int rows = cmd.ExecuteNonQuery();

            conn.Close();
            return rows > 0;
        }

        // --- RemoveDelivery ---
        public static bool RemoveDelivery(string deliveryId)
        {
            if (Validation.IsNullOrEmpty(deliveryId))
            {
                return false;
            }

            if (FindDelivery(deliveryId) == null)
            {
                return false;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "DELETE FROM Deliveries WHERE DeliveryId=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", deliveryId);
            int rows = cmd.ExecuteNonQuery();

            conn.Close();
            return rows > 0;
        }
    }
}
