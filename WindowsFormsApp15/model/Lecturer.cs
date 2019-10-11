using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsApp15.Data;

namespace WindowsFormsApp15.model
{
    public class Lecturer
    {
        private Guid lecturerID;
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
            init(Guid.NewGuid(), titleAndName, university, major);
        }

        /// <summary>
        /// Constructs a new Entity of Lecturer from a line from the datafiles.
        /// Should only be used when creating objects from files!
        /// </summary>
        /// <param name="line"></param>
        public Lecturer(string[] line)
        {
            DataSearch ds = new DataSearch();
            init(Guid.Parse(line[0]), line[1], ds.getByID<University>(Guid.Parse(line[2])),
                    ds.getByID<Major>(Guid.Parse(line[3])));
        }

        public University University { get => university; }
        public Guid LecturerID { get => lecturerID; }
        public string TitleAndName { get => titleAndName; }
        public Major Major { get => major; }

        public void setUniversity(University university)
        {
            if (university == null)
                throw new ArgumentNullException("university cannot be null.");
            this.university = university;
        }

        private void init(Guid lecturerID, string titleAndName, University university, Major major)
        {
            if (titleAndName == null) { throw new ArgumentNullException("titleAndName cannot be null."); }
            if (university == null) { throw new ArgumentNullException("university cannot be null."); }
            if (major == null) { throw new ArgumentNullException("major cannot be null."); }

            this.lecturerID = lecturerID;
            this.titleAndName = titleAndName;
            this.university = university;
            this.major = major;
        }

        /// <summary>
        /// Returns a String describing the Objects properties in the format:
        /// "lecturerID;titleAndName;universityID;majorID".
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string info = LecturerID.ToString() + ";" +
                TitleAndName + ";" +
                University.UniversityID.ToString() + ";" +
                Major.MajorID.ToString() + "\n";
            return info;
        }

        public Lecturer()
        {

        }
    }
}
