using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_Database.DL
{
    internal class StudentDL
    {
        public static string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=UAMS;Trusted_Connection=True;";

        //public static List<StudentBL> studentList = new List<StudentBL>();

        public static void AddStudent(StudentBL s)
        {
            string query = "INSERT INTO StudentTable (Name, Age, FscMarks, EcatMarks, Merit, RegDegree) " +
                           "VALUES (@name, @age, @fscMarks, @ecatMarks, @merit, @regDegree)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@name", s.GetName());
                command.Parameters.AddWithValue("@age", s.GetAge());
                command.Parameters.AddWithValue("@fscMarks", s.GetFSCMarks());
                command.Parameters.AddWithValue("@ecatMarks", s.GetECATMarks());
                command.Parameters.AddWithValue("@merit", s.GetMerit());
                command.Parameters.AddWithValue("@regDegree", s.GetRegDegree()?.GetTitle() ?? (object)DBNull.Value);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static List<StudentBL> GetAllStudents()
        {
            List<StudentBL> students = new List<StudentBL>();
            string query = "SELECT * FROM StudentTable";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    StudentBL student = new StudentBL(
                        Convert.ToString(reader["Name"]),
                        Convert.ToInt32(reader["Age"]),
                        Convert.ToSingle(reader["FscMarks"]),
                        Convert.ToSingle(reader["EcatMarks"])
                    );
                    students.Add(student);
                }
            }
            return students;
        }

        public static void UpdateRegDegree(string studentName, string degreeTitle)
        {
            string query = "UPDATE StudentTable SET RegDegree = @degree WHERE Name = @name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@degree", degreeTitle);
                command.Parameters.AddWithValue("@name", studentName);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static StudentBL FindByName(string name)
        {
            string query = "SELECT * FROM StudentTable WHERE Name = @name AND RegDegree IS NOT NULL";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    StudentBL student = new StudentBL(
                        Convert.ToString(reader["Name"]),
                        Convert.ToInt32(reader["Age"]),
                        Convert.ToSingle(reader["FscMarks"]),
                        Convert.ToSingle(reader["EcatMarks"])
                    );
                    return student;
                }
            }
            return null;
        }

        public static void ViewRegisteredStudents()
        {
            string query = "SELECT * FROM StudentTable WHERE RegDegree IS NOT NULL";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["Name"]}  {reader["Age"]}");
                }
            }
        }

        public static void ViewStudentsInDegree(string name)
        {
            string query = "SELECT * FROM StudentTable WHERE RegDegree = @degree";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@degree", name);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["Name"]}  {reader["Age"]}");
                }
            }
        }


        public static void CalculateFeeForAll()
        {
            string query = "SELECT * FROM StudentTable WHERE RegDegree IS NOT NULL";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    StudentBL student = new StudentBL(
                        Convert.ToString(reader["Name"]),
                        Convert.ToInt32(reader["Age"]),
                        Convert.ToSingle(reader["FscMarks"]),
                        Convert.ToSingle(reader["EcatMarks"])
                    );
                    Console.WriteLine($"{student.GetName()} has {student.CalculateFee()} fees");
                }
            }
        }
    }
}
