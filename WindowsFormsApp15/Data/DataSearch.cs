using GangsOfCsharp;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.model
{
    class DataSearch
    {
        private SQLiteConnection m_dbConnection;
        public DataSearch()
        {
            
        }

        public void Initialize()
        {
            SQLiteConnection.CreateFile("MyDatabase.sqlite");
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            string sql = "create table courses (courseID int, name varchar(150), " +
                "universityID int, lecturerID int, since varchar(10), numberOfRatings int)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            string sql1 = "insert into courses (courseID int, name varchar(150), " +
                "universityID int, lecturerID int, since varchar(10)) " +
                "values (1, AOOP, 1, 1, SS18, 5)";
            command = new SQLiteCommand(sql1, m_dbConnection);
            command.ExecuteNonQuery();
            sql = "select * from courses";
            command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while(reader.Read())
                Console.WriteLine("courseID: " + reader["courseID"] + 
                    "\tName: " + reader["name"] + 
                    "\tUni: " + reader["universityID"] + 
                    "\tLecturer: " + reader["lecturerID"] + 
                    "\tSince: " + reader["since"]);

            m_dbConnection.Close();

        }

        internal List<Major> getUniversitiesMajors(University university)
        {
            //select major from universities where universityID = university.ID
            return null;
        }

        public object[] UniversityNameSearch()
        {
            return new object[] {
            "Vilnius University",
            "Istanbul University",
            "Vilnius Gediminas Technical University",
            "Bogazici University",
            "Middle East Technical University",
            "Munich Technical University",
            "Berlin Technical University",
            "Heidelberg University"};
        }


        public List<string> GetAllMajorsFromUni(University university)
        {
            //select name from majors where universityID = university.ID;

            return null;
        }

        /// <summary>
        /// Adds the major to the database and returns its ID
        /// </summary>
        /// <param name="major"></param>
        /// <returns>Positive number</returns>
        public int AddMajor(Major major)
        {
            return 0;
        }

        public double CalculateAverageRatingForUniversity(University uni)
        {
            return 4.5;
        }

        public double CalculateAverageRatingForMajor(Major major)
        {
            return 4.5;
        }
        public double CalculateAverageRatingForLecturer(Lecturer lecturer)
        {
            //iterate through all courses with this lecturer and calculate average
            return 4.5;
        }
    }
}
