using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsApp15.model;

namespace GangsOfCsharp
{
    public class Course
    {
        private int courseID;
        private string courseName;
        private University university;
        private Major major;
        private Lecturer lecturer;
        private string since;


        /// <summary>
        /// Construtor for the class Course.
        /// Averages and amounts of rating categories will be set to 0.
        /// </summary>
        /// <param name="courseID">cannot be null</param>
        /// <param name="courseName">cannot be null</param>
        /// <param name="university">cannot be null</param>
        /// <param name="lecturer">cannot be null</param>
        /// <param name="since">cannot be null</param>
        /// <param name="major">cannot be null</param>
        public Course(int courseID, string name, University university, Lecturer lecturer, string since, Major major)
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

        public string Name { get => courseName; }
        public string Since { get => since; }
        public University University { get => university; }
        public Lecturer Lecturer { get => lecturer; }
        public Major Major { get => major; }
        public int CourseID { get => courseID; }
    }
}
