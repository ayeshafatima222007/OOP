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
    public class PaymentDL
    {
        // --- GetPaymentCount ---
        public static int GetPaymentCount()     //for payment id 
        {
            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Payments", conn);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count;
        }

        // --- AddPayment ---
        public static bool AddPayment(PaymentBL payment)
        {
            if (payment == null)
            {
                return false;
            }

            if (Validation.IsNullOrEmpty(payment.getPaymentId()))
            {
                return false;
            }

            if (Validation.IsNullOrEmpty(payment.getOrderId()))
            {
                return false;
            }

            if (!Validation.IsValidPaymentMethod(payment.getPaymentMethod()))
            {
                return false;
            }

            if (!Validation.IsValidAmount(payment.getAmount()))
            {
                return false;
            }

            if (FindPayment(payment.getPaymentId()) != null)
            {
                return false;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "INSERT INTO Payments (PaymentId, OrderId, Amount, PaymentMethod, IsPaid) VALUES(@id, @orderId, @amount, @method, @isPaid)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", payment.getPaymentId());
            cmd.Parameters.AddWithValue("@orderId", payment.getOrderId());
            cmd.Parameters.AddWithValue("@amount", payment.getAmount());
            cmd.Parameters.AddWithValue("@method", payment.getPaymentMethod());
            cmd.Parameters.AddWithValue("@isPaid", payment.getIsPaid());
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows > 0;
        }

        // --- FindPayment ---
        public static PaymentBL FindPayment(string paymentId)
        {
            if (Validation.IsNullOrEmpty(paymentId))
            {
                return null;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "SELECT * FROM Payments WHERE PaymentId=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", paymentId);
            SqlDataReader reader = cmd.ExecuteReader();

            PaymentBL payment = null;
            if (reader.Read())
            {
                payment = new PaymentBL(
                    reader["PaymentId"].ToString(),
                    reader["OrderId"].ToString(),
                    Convert.ToDouble(reader["Amount"]),
                    reader["PaymentMethod"].ToString()
                );
                payment.setIsPaid(Convert.ToBoolean(reader["IsPaid"]));
            }
            reader.Close();
            conn.Close();
            return payment;
        }

        // --- FindByOrder ---
        public static PaymentBL FindByOrder(string orderId)
        {
            if (Validation.IsNullOrEmpty(orderId))
            {
                return null;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "SELECT * FROM Payments WHERE OrderId=@orderId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@orderId", orderId);
            SqlDataReader reader = cmd.ExecuteReader();

            PaymentBL payment = null;
            if (reader.Read())
            {
                payment = new PaymentBL(
                    reader["PaymentId"].ToString(),
                    reader["OrderId"].ToString(),
                    Convert.ToDouble(reader["Amount"]),
                    reader["PaymentMethod"].ToString()
                );
                payment.setIsPaid(Convert.ToBoolean(reader["IsPaid"]));
            }
            reader.Close();
            conn.Close();
            return payment;
        }

        // --- UpdateIsPaid ---
        public static bool UpdateIsPaid(string paymentId, bool isPaid)
        {
            if (Validation.IsNullOrEmpty(paymentId))
            {
                return false;
            }

            if (FindPayment(paymentId) == null)
            {
                return false;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "UPDATE Payments SET IsPaid=@isPaid WHERE PaymentId=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", paymentId);
            cmd.Parameters.AddWithValue("@isPaid", isPaid);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows > 0;
        }

        // --- RemovePayment ---
        public static bool RemovePayment(string paymentId)
        {
            if (Validation.IsNullOrEmpty(paymentId))
            {
                return false;
            }

            if (FindPayment(paymentId) == null)
            {
                return false;
            }

            SqlConnection conn = Configuration.GetConnection();
            conn.Open();
            string query = "DELETE FROM Payments WHERE PaymentId=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", paymentId);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows > 0;
        }
    }
}