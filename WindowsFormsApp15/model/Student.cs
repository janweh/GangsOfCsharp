using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsApp15.Data;

namespace WindowsFormsApp15.model
{
    public class Student
    {
        private Guid studentID;
        private string studentName;
        private University university;
        private Major major;
        private string userName;
        private string password;
        private string areaOfStudies;
        private int currentSemester;

        /// <summary>
        /// Constructs a new Entity of Student from a line from the datafiles.
        /// Should only be used when creating objects from files!
        /// </summary>
        /// <param name="line"></param>
        public Student(string[] r)
        {
            DataSearch ds = new DataSearch();
            init(Guid.Parse(r[0]), r[1], r[2], r[3], ds.getByID<University>(Guid.Parse(r[4])),
                ds.getByID<Major>(Guid.Parse(r[5])), r[6], Int32.Parse(r[7]));
        }

        /// <summary>
        /// Constructor for class Student with manually assigning a studentID.
        /// Should be used when recreating an object from the datafile
        /// </summary>
        /// <param name="studentID">cannot be null</param>
        /// <param name="studentName">cannot be null</param>
        /// <param name="university">cannot be null</param>
        /// <param name="major">cannot be null</param>
        /// <param name="userName">cannot be null</param>
        /// <param name="password">cannot be null</param>
        /// <param name="areaOfStudies">can be null</param>
        /// <param name="semester">can be null</param>
        public Student(Guid studentID, string userName, string password, string studentName, University university,
            Major major, string areaOfStudies, int semester)
        {
            init(studentID, userName, password, studentName, university, major, areaOfStudies, semester);
        }

        public string StudentName { get => studentName;}
        public void setStudentName(string studentName)
        {
            if (studentName == null)
                throw new ArgumentNullException("studentName cannot be set to null.");
            this.studentName = studentName;
        }
        public string UserName { get => userName; }
        public void setUserName(string userName)
        {
            if (userName == null)
                throw new ArgumentNullException("userName cannot be set to null.");
            this.userName = userName;
        }
        public string Password { get => password; }
        public void setPassword(string password)
        {
            if (password == null)
                throw new ArgumentNullException("password cannot be set to null.");
            this.password = password;
        }
        public string AreaOfStudies { get => areaOfStudies; }
        public void setAreaOfStudies(string areaOfStudies)
        {
            if (areaOfStudies == null)
                throw new ArgumentNullException("areaOfStudies cannot be set to null.");
            this.areaOfStudies = areaOfStudies;
        }
        public int Semester { get => currentSemester; }
        public Guid StudentID { get => studentID; }
        public University University { get => university; }
        public Major Major { get => major; }

        public void setSemester(int semester)
        {
            this.currentSemester = semester;
        }

        private void init(Guid studentID, string userName, string password, string studentName, University university,
            Major major, string areaOfStudies, int semester)
        {
            if (userName == null)
            {
                throw new ArgumentNullException("UserName cannot be null");
            }
            if (password == null)
            {
                throw new ArgumentNullException("password cannot be null");
            }
            if (university == null) { throw new ArgumentNullException("university cannot be null!"); }
            if (major == null) { throw new ArgumentNullException("major cannot be null!"); }

            this.studentID = studentID;
            this.userName = userName;
            this.password = password;
            this.studentName = studentName;
            this.university = university;
            this.major = major;
            this.areaOfStudies = areaOfStudies;
            this.currentSemester = semester;
        }

        /// <summary>
        /// Returns a string containing the objects properties in the format:
        /// "studentID;universityID;majorID;studentName;
        /// userName;password;areaOfStudies;currentSemester"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string info = StudentID.ToString() + ";" +
                UserName + ";" +
                Password + ";" +
                StudentName + ";" +
                University.UniversityID.ToString() + ";" +
                Major.MajorID.ToString() + ";" +
                AreaOfStudies + ";" +
                Semester.ToString() + "\n";
            return info;
        }
    }
}
