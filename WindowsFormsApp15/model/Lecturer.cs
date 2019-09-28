using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsApp15.model;

namespace GangsOfCsharp
{
    public class Lecturer
    {
        private int lecturerID;
        private string titleAndName;
        private University university;
        private Major major;

        /// <summary>
        /// Constructor for the class Lecturer without giving a lecturerID.
        /// ID will be generated autmatically.
        /// Should be used when creating a truly new object that is not yet stored.
        /// </summary>
        /// <param name="titleAndName">cannot be null</param>
        /// <param name="university">cannot be null</param>
        /// <param name="major">cannot be null</param>
        public Lecturer(string titleAndName, University university, Major major)
        {
            DataSearch ds = new DataSearch();
            init(ds.getNextLecturerID(), titleAndName, university, major);
        }

        /// <summary>
        /// Constructor for the class Lecturer with manually assigning the lecturerID.
        /// Should be used when recreating an object from the datafile
        /// </summary>
        /// <param name="lecturerID">cannot be null</param>
        /// <param name="titleAndName">cannot be null</param>
        /// <param name="university">cannot be null</param>
        /// <param name="major">cannot be null</param>
        public Lecturer(int lecturerID, string titleAndName, University university, Major major)
        {
            init(lecturerID, titleAndName, university, major);
        }

        public University University { get => university; }
        public int LecturerID { get => lecturerID; }
        public string TitleAndName { get => titleAndName; }
        public Major Major { get => major; }

        public void setUniversity(University university)
        {
            if (university == null)
                throw new ArgumentNullException("university cannot be null.");
            this.university = university;
        }

        private void init(int lecturerID, string titleAndName, University university, Major major)
        {
            if (titleAndName == null) { throw new ArgumentNullException("titleAndName cannot be null."); }
            if (university == null) { throw new ArgumentNullException("university cannot be null."); }
            if (major == null) { throw new ArgumentNullException("major cannot be null."); }

            this.lecturerID = lecturerID;
            this.titleAndName = titleAndName;
            this.university = university;
            this.major = major;
        }
    }
}
