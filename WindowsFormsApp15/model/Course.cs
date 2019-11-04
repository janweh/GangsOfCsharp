using System;
using WindowsFormsApp15.Data;

namespace WindowsFormsApp15.model
{
    public class Course
    {
        private Guid courseID;
        private string courseName;
        private University university;
        private Major major;
        private Lecturer lecturer;
        private Semester since;

        /// <summary>
        /// Construtor for the class Course without giving a courseID.
        /// Averages and amounts of rating categories will be set to 0.
        /// ID will be generated automatically.
        /// Should be used when creating a truly new object that is not yet stored.
        /// </summary>
        /// <param name="courseName">cannot be null</param>
        /// <param name="university">cannot be null</param>
        /// <param name="lecturer">cannot be null</param>
        /// <param name="since">cannot be null</param>
        /// <param name="major">cannot be null</param>
        public Course(string name, University university, Lecturer lecturer, Semester since, Major major)
        {
            DataSearch ds = new DataSearch();
            Init(Guid.NewGuid(), name, university, lecturer, since, major);
        }

        /// <summary>
        /// Constructs a new Entity of Course from a line from the datafiles.
        /// Should only be used when creating objects from files!
        /// </summary>
        /// <param name="line"></param>
        public Course(string[] line)
        {
            DataSearch ds = new DataSearch();
                
            Init(Guid.Parse(line[0]), line[1], ds.GetByID<University>(Guid.Parse(line[2])),
                ds.GetByID<Lecturer>(Guid.Parse(line[3])), EnumTranslator.stringToSemester[line[4]], ds.GetByID<Major>(Guid.Parse(line[5])));
        }

        public string Name { get => courseName; }
        public Semester Since { get => since; }
        public University University { get => university; }
        public Lecturer Lecturer { get => lecturer; }
        public Major Major { get => major; }
        public Guid CourseID { get => courseID; }

        private void Init(Guid courseID, string name, University university, Lecturer lecturer, Semester since, Major major)
        {
            this.courseID = courseID;
            this.courseName = name ?? throw new ArgumentNullException("name cannot be null.");
            this.university = university ?? throw new ArgumentNullException("university cannot be null.");
            this.lecturer = lecturer ?? throw new ArgumentNullException("lecturer cannot be null.");
            this.since = since;
            this.major = major ?? throw new ArgumentNullException("major cannot be null.");
        }

        /// <summary>
        /// Return string containing the objects properties in the format:
        /// "courseID;courseName;universityID;majorID;lecturerID;since".
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string resultString = CourseID.ToString() + ";" +
                Name + ";" +
                University.UniversityID.ToString() + ";" +
                Lecturer.LecturerID.ToString() + ";" +
                EnumTranslator.semesterToString[Since] + ";" +
                Major.MajorID.ToString() + "\n";
            return resultString;
        }

        public Course()
        {

        }
    }
}
