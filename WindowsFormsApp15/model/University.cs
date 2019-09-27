using System;
using System.Collections.Generic;

namespace GangsOfCsharp
{
    public class University
    {
        private int universityID;
        private string universityName;

        /// <summary>
        /// Constructor for the class University
        /// </summary>
        /// <param name="universityID">cannot be null</param>
        /// <param name="name">cannot be null</param>
        public University(int universityID, string name)
        {
            if (name == null)
                throw new ArgumentNullException("name cannot be null.");
            this.universityName = name;
            this.universityID = universityID;
        }

        public string UniversityName { get => universityName; }
        public int UniversityID { get => universityID; }
    }
}
