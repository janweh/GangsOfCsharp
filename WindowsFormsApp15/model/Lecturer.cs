using System;
using System.Collections.Generic;
using System.Text;

namespace GangsOfCsharp
{
    public class Lecturer
    {
        private int lecturerID;
        private string titleAndName;
        private University university;

        /// <summary>
        /// Constructor for the class Lecturer
        /// </summary>
        /// <param name="lecturerID">cannot be null</param>
        /// <param name="titleAndName">cannot be null</param>
        /// <param name="university">cannot be null</param>
        public Lecturer(int lecturerID, string titleAndName, University university)
        {
            if(titleAndName == null) { throw new ArgumentNullException("titleAndName cannot be null."); }
            if (university == null) { throw new ArgumentNullException("university cannot be null."); }

            this.lecturerID = lecturerID;
            this.titleAndName = titleAndName;
            this.university = university;
        }

        
        public University University { get => university; }
        public int LecturerID { get => lecturerID; }
        public string TitleAndName { get => titleAndName; }


        public void setUniversity(University university)
        {
            if (university == null)
                throw new ArgumentNullException("university cannot be null.");
            this.university = university;
        }
    }
}
