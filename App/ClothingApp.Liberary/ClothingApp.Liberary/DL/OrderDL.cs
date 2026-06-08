using ClothingApp.Library.BL;
using ClothingApp.Library.DL;
using ClothingApp.Library.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingApp.Library.DL
{
    public class OrderDL
    {
        // --- AddOrder ---
        public static bool AddOrder(OrderBL ord)
        {
            if (ord == null)
            {
                return false;
            }
            if (Validation.IsNullOrEmpty(ord.getOrderId()))
            {
                return false;
            }
            if (FindOrder(ord.getOrderId()) != null)
            {
                return false;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "INSERT INTO Orders (OrderId, BuyerUsername, Status, OrderDate) VALUES(@id, @buyer, @status, @date)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", ord.getOrderId());
            cmd.Parameters.AddWithValue("@buyer", ord.getBuyer().getUsername());
            cmd.Parameters.AddWithValue("@status", ord.getStatus());
            cmd.Parameters.AddWithValue("@date", ord.getOrderDate());
            int rows = cmd.ExecuteNonQuery();

            conn.Close();
            return rows > 0;
        }

        // --- FindOrder ---
        public static OrderBL FindOrder(string orderId)
        {
            if (Validation.IsNullOrEmpty(orderId))
            {
                return null;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "SELECT * FROM Orders WHERE OrderId=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", orderId);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string buyerUsername = reader["BuyerUsername"].ToString();
                string status = reader["Status"].ToString();
                DateTime date = Convert.ToDateTime(reader["OrderDate"]);
                string oid = reader["OrderId"].ToString();
                reader.Close();
                conn.Close();

                UserDL userDL = new UserDL();
                UserBL user = userDL.FindByUsername(buyerUsername);

                if (user == null)
                {
                    return null;
                }

                BuyerBL buyer = new BuyerBL(user.getUsername(), user.getPassword(), user.getPhoneNumber(), "");
                OrderBL ord = new OrderBL(oid, buyer);
                ord.setStatus(status);
                ord.setOrderDate(date);
                return ord;
            }

            reader.Close();
            conn.Close();
            return null;
        }

        // --- FindOrdersByBuyer ---
        public static List<OrderBL> FindOrdersByBuyer(string username)
        {
            List<OrderBL> result = new List<OrderBL>();
            if (Validation.IsNullOrEmpty(username))
            {
                return result;
            }

            UserDL userDL = new UserDL();
            UserBL user = userDL.FindByUsername(username);

            if (user == null)
            {
                return result;
            }

            BuyerBL buyer = new BuyerBL(user.getUsername(), user.getPassword(), user.getPhoneNumber(), "");

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();

            string query = "SELECT * FROM Orders WHERE BuyerUsername=@buyer";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@buyer", username);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                OrderBL ord = new OrderBL(reader["OrderId"].ToString(), buyer);
                ord.setStatus(reader["Status"].ToString());
                ord.setOrderDate(Convert.ToDateTime(reader["OrderDate"]));
                result.Add(ord);
            }
            reader.Close();
            conn.Close();
            return result;
        }

        // --- GetAllOrders ---
        public static List<OrderBL> GetAllOrders()
        {
            List<OrderBL> result = new List<OrderBL>();
            List<(string oid, string buyerUsername, string status, DateTime date)> raw = new List<(string, string, string, DateTime)>();

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Orders", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                raw.Add((
                    reader["OrderId"].ToString(),
                    reader["BuyerUsername"].ToString(),
                    reader["Status"].ToString(),
                    Convert.ToDateTime(reader["OrderDate"])
                ));
            }
            reader.Close();
            conn.Close();

            foreach (var r in raw)
            {
                UserDL userDL = new UserDL();
                UserBL user = userDL.FindByUsername(r.buyerUsername);
                if (user == null) continue;
                BuyerBL buyer = new BuyerBL(user.getUsername(), user.getPassword(), user.getPhoneNumber(), "");
                OrderBL ord = new OrderBL(r.oid, buyer);
                ord.setStatus(r.status);
                ord.setOrderDate(r.date);
                result.Add(ord);
            }
            return result;
        }

        // --- UpdateStatus ---
        public static bool UpdateStatus(string orderId, string newStatus)
        {
            if (Validation.IsNullOrEmpty(orderId))
            {
                return false;
            }

            if (Validation.IsNullOrEmpty(newStatus))
            {
                return false;
            }

            if (FindOrder(orderId) == null)
            {
                return false;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "UPDATE Orders SET Status=@status WHERE OrderId=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", orderId);
            cmd.Parameters.AddWithValue("@status", newStatus);
            int rows = cmd.ExecuteNonQuery();

            conn.Close();
            return rows > 0;
        }

        // --- RemoveOrder ---
        public static bool RemoveOrder(string orderId)
        {
            if (Validation.IsNullOrEmpty(orderId))
            {
                return false;
            }

            if (FindOrder(orderId) == null)
            {
                return false;
            }

            //find by order first, then remove using correct Id

            DeliveryBL delivery = DeliveryDL.FindByOrder(orderId);

            if (delivery != null)
            {
                DeliveryDL.RemoveDelivery(delivery.getDeliveryId());
            }

            PaymentBL payment = PaymentDL.FindByOrder(orderId);

            if (payment != null)
            {
                PaymentDL.RemovePayment(payment.getPaymentId());
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "DELETE FROM Orders WHERE OrderId=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", orderId);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows > 0;
        }
    }
}