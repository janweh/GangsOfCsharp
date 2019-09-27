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
        /// </summary>
        /// <param name="university"></param>
        /// <exception cref="ArgumentException">universityID allready exists in the file.</exception>
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
        /// Finds the University with the given id by iterating through the UniversityStorage file.
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="KeyNotFoundException">id does not match any of the universityIDs in the file or the id occurs multiple times</exception>
        /// <returns>the university with the given ID</returns>
        public University getByUniversityID(int id)
        {
            Func<string[], bool> matches = (x) => x[0].Equals(id.ToString());
            List<string[]> matchingLines = getAllMatchingLines(matches, universitiesPath);
            if(matchingLines == null)
            {
                throw new KeyNotFoundException("id did not match any universityID in the file.");
            } else if(matchingLines.Count != 1)
            {
                throw new KeyNotFoundException("id occured multiple times in the file.");
            }
            string[] r = matchingLines.First();
            University university = new University(Int32.Parse(r[0]), r[1]);
            return university;
        }

        /// <summary>
        /// Returns all stored universities
        /// </summary>
        /// <returns>All universities in the UniversityStorage file</returns>
        public List<University> getAllUniversities()
        {
            List<University> unis = new List<University>();
            Func<string[], bool> matches = (x) => true;
            List<string[]> matchingLines = getAllMatchingLines(matches, universitiesPath);
            foreach(string[] r in matchingLines)
            {
                University uni = new University(Int32.Parse(r[0]), r[1]);
                unis.Add(uni);
            }
            return unis;
        }

        /// <summary>
        /// Stores the lecturer in a file with all the other lecturers.
        /// Format of storage: "lecturerID;titleAndName;universityID"
        /// </summary>
        /// <param name="lecturer"></param>
        /// <exception cref="ArgumentException">lecturerID allready exists in the file.</exception>
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
        /// </summary>
        /// <param name="course"></param>
        /// <exception cref="ArgumentException">courseID allready exists in the file.</exception>
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
        /// </summary>
        /// <param name="rating"></param>
        /// <exception cref="ArgumentException">ratingID allready exists in the file.</exception>
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
        /// </summary>
        /// <param name="student"></param>
        /// <exception cref="ArgumentException">studentID allready exists in the file.</exception>
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
        /// </summary>
        /// <param name="major"></param>
        /// <exception cref="ArgumentException">majorID allready exists in the file.</exception>
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

        private List<string[]> getAllMatchingLines(Func<string[], bool> match, string path)
        {
            List<string[]> results = new List<string[]>();
            using (StreamReader sr = File.OpenText(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(';');
                    if (match(splitLine))
                        results.Add(splitLine);

                }
            }
            return results;
        }
    }
}
