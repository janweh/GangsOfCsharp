using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsApp15.model;

namespace GangsOfCsharp
{
    public class Course
    {
        private Guid courseID;
        private string courseName;
        private University university;
        private Major major;
        private Lecturer lecturer;
        private string since;


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
        public Course(string name, University university, Lecturer lecturer, string since, Major major)
        {
            DataSearch ds = new DataSearch();
            init(Guid.NewGuid(), name, university, lecturer, since, major);
        }

        /// <summary>
        /// Constructs a new Entity of Course from a line from the datafiles.
        /// Should only be used when creating objects from files!
        /// </summary>
        /// <param name="line"></param>
        public Course(string[] line)
        {
            DataSearch ds = new DataSearch();
            init(Guid.Parse(line[0]), line[1], ds.getByID<University>(Guid.Parse(line[2])),
                ds.getByID<Lecturer>(Guid.Parse(line[3])), line[4], ds.getByID<Major>(Guid.Parse(line[5])));
        }

        public string Name { get => courseName; }
        public string Since { get => since; }
        public University University { get => university; }
        public Lecturer Lecturer { get => lecturer; }
        public Major Major { get => major; }
        public Guid CourseID { get => courseID; }

        private void init(Guid courseID, string name, University university, Lecturer lecturer, string since, Major major)
        {
            if (name == null)
                throw new ArgumentNullException("name cannot be null.");
            if (university == null)
                throw new ArgumentNullException("university cannot be null.");
            if (lecturer == null)
                throw new ArgumentNullException("lecturer cannot be null.");
            if (since == null)
                throw new ArgumentNullException("since cannot be null.");
            if (major == null)
                throw new ArgumentNullException("major cannot be null.");

            this.courseID = courseID;
            this.courseName = name;
            this.university = university;
            this.lecturer = lecturer;
            this.since = since;
            this.major = major;
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
                Since + ";" +
                Major.MajorID.ToString() + "\n";
            return resultString;
        }
    }
}
