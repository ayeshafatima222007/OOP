using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_Database.BL;

namespace UAMS_Database.DL
{
    internal class DegreeProgramDL
    {
        public static string connectionString = StudentDL.connectionString;

        // Keep this for in-memory use (needed in Program.cs for seats/preferences)
        public static List<DegreeProgramBL> programList = new List<DegreeProgramBL>();

        public static void AddDegreeProgram(DegreeProgramBL d)
        { 
            programList.Add(d);

            // Add to database
            string query = "INSERT INTO DegreeProgramTable (Title, Duration, Seats) " +
                           "VALUES (@title, @duration, @seats)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@title", d.GetTitle());
                command.Parameters.AddWithValue("@duration", d.GetDuration());
                command.Parameters.AddWithValue("@seats", d.GetSeats());
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static List<DegreeProgramBL> GetAllDegreePrograms()
        {
            List<DegreeProgramBL> programs = new List<DegreeProgramBL>();
            string query = "SELECT * FROM DegreeProgramTable";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DegreeProgramBL program = new DegreeProgramBL(
                        Convert.ToString(reader["Title"]),
                        Convert.ToSingle(reader["Duration"]),
                        Convert.ToInt32(reader["Seats"])
                    );
                    programs.Add(program);
                }
            }
            return programs;
        }

        public static void UpdateSeats(string title, int seats)
        {
            string query = "UPDATE DegreeProgramTable SET Seats = @seats WHERE Title = @title";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@seats", seats);
                command.Parameters.AddWithValue("@title", title);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
