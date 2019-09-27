using GangsOfCsharp;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.model
{
    class DataSearch
    {
        private string coursePath;
        private string lecturerPath;
        private string majorPath;
        private string ratingPath;
        private string studentPath;
        private string universitiesPath;
        //unneeded
        private SQLiteConnection m_dbConnection;
        public DataSearch()
        {
            //initializes all the paths to the folders which hold the data
            string folder = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            coursePath = Path.Combine(folder, @"Data\", "CourseStorage.txt");
            lecturerPath = Path.Combine(folder, @"Data\", "LecturerStorage.txt");
            majorPath = Path.Combine(folder, @"Data\", "MajorStorage.txt");
            ratingPath = Path.Combine(folder, @"Data\", "RatingStorage.txt");
            studentPath = Path.Combine(folder, @"Data\", "StudentStorage.txt");
            universitiesPath = Path.Combine(folder, @"Data\", "UniversityStorage.txt");
        }

        /// <summary>
        /// Stores the university in a file with all the other universities.
        /// Format of storage: "universityID;universityName"
        /// Will throw a ArgumentException if the universityID allready excists in the file!!!
        /// This ArgumentException should be handled with try/catch!
        /// </summary>
        /// <param name="university"></param>
        public void store(University university)
        {
            checkDuplicateID(university);
            string info = university.UniversityID.ToString() + ";" + 
                university.UniversityName + "\n";
            File.AppendAllText(universitiesPath, info);
        }

        private void checkDuplicateID(University university)
        {
            using(StreamReader sr = File.OpenText(universitiesPath))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    if (parts[0].Equals(university.UniversityID.ToString()))
                        throw new ArgumentException("this universityID is allready used!");
                }
            }
        }


        /// <summary>
        /// Stores the lecturer in a file with all the other lecturers.
        /// Format of storage: "lecturerID;titleAndName;universityID"
        /// Will throw a ArgumentException if the lecturerID allready excists in the file!!!
        /// This ArgumentException should be handled with try/catch!
        /// </summary>
        /// <param name="lecturer"></param>
        public void store(Lecturer lecturer)
        {
            checkDuplicateID(lecturer);
            string info = lecturer.LecturerID.ToString() + ";" +
                lecturer.TitleAndName + ";" +
                lecturer.University.UniversityID.ToString() + "\n";
            File.AppendAllText(lecturerPath, info);
        }

        private void checkDuplicateID(Lecturer lecturer)
        {
            using (StreamReader sr = File.OpenText(lecturerPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    if (parts[0].Equals(lecturer.LecturerID.ToString()))
                        throw new ArgumentException("this lecturerID is allready used!");
                }
            }
        }

        /// <summary>
        /// Stores the course in a file with all the other courses.
        /// Format of storage: "courseID;courseName;universityID;majorID;lecturerID;since"
        /// Will throw a ArgumentException if the courseID allready excists in the file!!!
        /// This ArgumentException should be handled with try/catch!
        /// </summary>
        /// <param name="course"></param>
        public void store(Course course)
        {
            checkDuplicateID(course);
            string info = course.CourseID.ToString() + ";" +
                course.Name + ";" +
                course.University.UniversityID.ToString() + ";" +
                course.Major.MajorID.ToString() + ";" +
                course.Lecturer.LecturerID.ToString() + ";" +
                course.Since + "\n";
            File.AppendAllText(coursePath, info);
        }

        private void checkDuplicateID(Course course)
        {
            using (StreamReader sr = File.OpenText(coursePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    if (parts[0].Equals(course.CourseID.ToString()))
                        throw new ArgumentException("this courseID is allready used!");
                }
            }
        }

        /// <summary>
        /// Stores the rating in a file with all the other ratings.
        /// Format of storage: "ratingID;studentID;courseID;ratedSemester;overallRating;
        /// contactHours;selfStudyHours;organized;learned;interesting;
        /// presentation;comment"
        /// Will throw a ArgumentException if the ratingID allready excists in the file!!!
        /// This ArgumentException should be handled with try/catch!
        /// </summary>
        /// <param name="rating"></param>
        public void store(Rating rating)
        {
            checkDuplicateID(rating);
            string info = rating.RatingID.ToString() + ";" +
                rating.Student.StudentID.ToString() + ";" +
                rating.Course.CourseID.ToString() + ";" +
                rating.Semester + ";" +
                rating.OverallRating.ToString() + ";" +
                rating.ContactHours.ToString() + ";" +
                rating.SelfStudyHours.ToString() + ";" +
                rating.Organized.ToString() + ";" +
                rating.Learned.ToString() + ";" +
                rating.Interesting.ToString() + ";" +
                rating.Presentation.ToString() + ";" +
                rating.Comment + "\n";
                File.AppendAllText(ratingPath, info);
        }

        private void checkDuplicateID(Rating rating)
        {
            using (StreamReader sr = File.OpenText(ratingPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    if (parts[0].Equals(rating.RatingID.ToString()))
                        throw new ArgumentException("this ratingID is allready used!");
                }
            }
        }

        /// <summary>
        /// Stores the student in a file with all the other students.
        /// Format of storage: "studentID;universityID;majorID;studentName;
        /// userName;password;areaOfStudies;currentSemester"
        /// Will throw a ArgumentException if the studentID allready excists in the file!!!
        /// This ArgumentException should be handled with try/catch!
        /// </summary>
        /// <param name="student"></param>
        public void store(Student student)
        {
            checkDuplicateID(student);
            string info = student.StudentID.ToString() + ";" +
                student.University.UniversityID.ToString() + ";" +
                student.Major.MajorID.ToString() + ";" +
                student.StudentName + ";" +
                student.UserName + ";" +
                student.Password + ";" +
                student.AreaOfStudies + ";" +
                student.Semester.ToString() +"\n";
            File.AppendAllText(studentPath, info);
        }

        private void checkDuplicateID(Student student)
        {
            using (StreamReader sr = File.OpenText(studentPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    if (parts[0].Equals(student.StudentID.ToString()))
                        throw new ArgumentException("this studentID is allready used!");
                }
            }
        }

        /// <summary>
        /// Stores the major in a file with all the other majors.
        /// Format of storage: "majorID;majorName;universityID"
        /// Will throw a ArgumentException if the majorID allready excists in the file!!!
        /// This ArgumentException should be handled with try/catch!
        /// </summary>
        /// <param name="major"></param>
        public void store(Major major)
        {
            checkDuplicateID(major);
            string info = major.MajorID.ToString() + ";" +
                major.Name + ";"  +
                major.University.UniversityID.ToString() + "\n";
            File.AppendAllText(majorPath, info);
        }

        private void checkDuplicateID(Major major)
        {
            using (StreamReader sr = File.OpenText(majorPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    if (parts[0].Equals(major.MajorID.ToString()))
                        throw new ArgumentException("this majorID is allready used!");
                }
            }
        }

        //this is old code but i left it in there because we may need it when we create a database
        /*public void Initialize()
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

        }*/

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
