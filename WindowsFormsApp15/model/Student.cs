using System;
using WindowsFormsApp15.Data;

namespace WindowsFormsApp15.model
{
    public class Student : Storable
    {
        private Guid studentID;
        private University university;
        private string userName;
        private string password;
        private string areaOfStudies;

        /// <summary>
        /// Constructs a new Entity of Student from a line from the datafiles.
        /// Should only be used when creating objects from files!
        /// </summary>
        /// <param name="line"></param>
        public Student(string[] r)
        {
            DataSearch ds = new DataSearch();
            University u;
            try
            {
                u = ds.GetByID<University>(Guid.Parse(r[3]));
            }
            catch (DuplicateDataException)
            {
                u = new University();
            }
            Init(Guid.Parse(r[0]), r[1], r[2], u, r[5]);
        }

        /// <summary>
        /// Constructor for class Student with manually assigning a studentID.
        /// Should be used when recreating an object from the datafile
        /// </summary>
        /// <param name="studentID">cannot be null</param>
        /// <param name="studentName">cannot be null</param>
        /// <param name="university">cannot be null</param>
        /// <param name="userName">cannot be null</param>
        /// <param name="password">cannot be null</param>
        /// <param name="areaOfStudies">can be null</param>
        public Student(string userName, string password, University university,
            string areaOfStudies)
        {
            Init(Guid.NewGuid(), userName, password, university, areaOfStudies);
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
        public override Guid ID { get => studentID; }
        public University University { get => university; }

        private void Init(Guid studentID, string userName, string password, University university,
             string areaOfStudies)
        {
            this.studentID = studentID;
            this.userName = userName ?? throw new ArgumentNullException("UserName cannot be null");
            this.password = password ?? throw new ArgumentNullException("password cannot be null");
            this.university = university ?? throw new ArgumentNullException("university cannot be null!");
            this.areaOfStudies = areaOfStudies;
        }

        /// <summary>
        /// Returns a string containing the objects properties in the format:
        /// "studentID;universityID;majorID;studentName;
        /// userName;password;areaOfStudies;currentSemester"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string info = ID.ToString() + ";" +
                UserName + ";" +
                Password + ";" +
                University.ID.ToString() + ";" +
                AreaOfStudies + ";" + "\n";
            return info;
        }

        public Student() : base() { }
    }
}
