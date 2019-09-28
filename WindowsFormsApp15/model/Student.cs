using System;
using System.Collections.Generic;
using System.Text;

namespace GangsOfCsharp
{
    public class Student
    {
        private int studentID;
        private string studentName;
        private University university;
        private Major major;
        private string userName;
        private string password;
        private string areaOfStudies;
        private int currentSemester;

        /// <summary>
        /// Constructor for class Student with giving a studentID.
        /// ID will be automatically generated.
        /// Should be used when creating a truly new object that is not yet stored.
        /// </summary>
        /// <param name="studentName">cannot be null</param>
        /// <param name="university">cannot be null</param>
        /// <param name="major">cannot be null</param>
        /// <param name="userName">cannot be null</param>
        /// <param name="password">cannot be null</param>
        /// <param name="areaOfStudies">can be null</param>
        /// <param name="semester">can be null</param>
        public Student(string userName, string password, string studentName, University university, 
            Major major, string areaOfStudies, int semester)
        {
            WindowsFormsApp15.model.DataSearch ds = new WindowsFormsApp15.model.DataSearch();
            init(ds.getNextStudentID(), userName, password, studentName, university, major, areaOfStudies, semester);
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
        public Student(int studentID, string userName, string password, string studentName, University university,
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
        public int StudentID { get => studentID; }
        public University University { get => university; }
        public Major Major { get => major; }

        public void setSemester(int semester)
        {
            this.currentSemester = semester;
        }

        private void init(int studentID, string userName, string password, string studentName, University university,
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
    }
}
