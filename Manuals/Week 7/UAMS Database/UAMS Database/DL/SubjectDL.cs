using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_Database.BL;

namespace UAMS_Database.DL
{
    internal class SubjectDL
    {
        public static string connectionString = StudentDL.connectionString;

        public static void AddSubject(SubjectBL s, string degreeTitle)
        {
            string query = "INSERT INTO Subject (SubjectCode, CreditHours, SubjectType, SubjectFee, DegreeTitle) " +
                           "VALUES (@subjCode, @crh, @subjType, @subjFee, @degreeTitle)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@subjCode", s.GetSubjCode());
                command.Parameters.AddWithValue("@crh", s.GetCRH());
                command.Parameters.AddWithValue("@subjType", s.GetSubjType());
                command.Parameters.AddWithValue("@subjFee", s.GetSubjFee());
                command.Parameters.AddWithValue("@degreeTitle", degreeTitle);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static SubjectBL FindByCode(List<SubjectBL> subjects, string code)
        {
            foreach (SubjectBL s in subjects)
                if (s.GetSubjCode() == code)
                    return s;
            return null;
        }

        public static List<SubjectBL> GetSubjectsByDegree(string degreeTitle)
        {
            List<SubjectBL> subjects = new List<SubjectBL>();
            string query = "SELECT * FROM Subject WHERE DegreeTitle = @degreeTitle";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@degreeTitle", degreeTitle);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    SubjectBL subject = new SubjectBL(Convert.ToString(reader["SubjCode"]),Convert.ToInt32(reader["CRH"]),Convert.ToString(reader["SubjType"]),Convert.ToSingle(reader["SubjFee"]));
                    subjects.Add(subject);
                }
            }
            return subjects;
        }
    }
}
