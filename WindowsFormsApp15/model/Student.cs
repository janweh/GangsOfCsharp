using System;
using WindowsFormsApp15.Data;

namespace WindowsFormsApp15.model
{
    public class Student
    {
        private Guid studentID;
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
            Init(Guid.Parse(r[0]), r[1], r[2], ds.GetByID<University>(Guid.Parse(r[3])),
                ds.GetByID<Major>(Guid.Parse(r[4])), r[5], Int32.Parse(r[6]));
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
        public Student(string userName, string password, University university,
            Major major, string areaOfStudies, int semester)
        {
            Init(Guid.NewGuid(), userName, password, university, major, areaOfStudies, semester);
        }

        public string UserName { get => userName; }
        public void SetUserName(string userName)
        {
            this.userName = userName ?? throw new ArgumentNullException("userName cannot be set to null.");
        }
        public string Password { get => password; }
        public void SetPassword(string password)
        {
            this.password = password ?? throw new ArgumentNullException("password cannot be set to null.");
        }
        public string AreaOfStudies { get => areaOfStudies; }
        public void SetAreaOfStudies(string areaOfStudies)
        {
            this.areaOfStudies = areaOfStudies ?? throw new ArgumentNullException("areaOfStudies cannot be set to null.");
        }
        public int Semester { get => currentSemester; }
        public Guid StudentID { get => studentID; }
        public University University { get => university; }
        public Major Major { get => major; }

        public void SetSemester(int semester)
        {
            this.currentSemester = semester;
        }

        private void Init(Guid studentID, string userName, string password, University university,
            Major major, string areaOfStudies, int semester)
        {
            this.studentID = studentID;
            this.userName = userName ?? throw new ArgumentNullException("UserName cannot be null");
            this.password = password ?? throw new ArgumentNullException("password cannot be null");
            this.university = university ?? throw new ArgumentNullException("university cannot be null!");
            this.major = major ?? throw new ArgumentNullException("major cannot be null!");
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
                University.UniversityID.ToString() + ";" +
                Major.MajorID.ToString() + ";" +
                AreaOfStudies + ";" +
                Semester.ToString() + "\n";
            return info;
        }

        public Student()
        {

        }
    }
}
