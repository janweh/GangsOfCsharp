using System;
using System.Collections.Generic;

namespace GangsOfCsharp
{
    public class University
    {
        private int universityID;
        private string universityName;

        /// <summary>
        /// Constructor for the class University without giving an ID.
        /// ID will be generated automatically.
        /// Should be used when creating a truly new object that is not yet stored.
        /// </summary>
        /// <param name="name">cannot be null</param>
        public University(string name)
        {
            WindowsFormsApp15.model.DataSearch ds = new WindowsFormsApp15.model.DataSearch();
            init(ds.getNextUniversityID(), name);
        }

        /// <summary>
        /// Constructor for the class University with a manually assigned ID.
        /// Should be used when recreating an object from the datafile
        /// <param name="universityID">cannot be null</param>
        /// <param name="name">cannot be null</param>
        public University(int universityID, string name)
        {
            init(universityID, name);
        }

        public string UniversityName { get => universityName; }
        public int UniversityID { get => universityID; }

        private void init(int universityID, string name)
        {
            if (name == null)
                throw new ArgumentNullException("name cannot be null.");

            this.universityName = name;
            this.universityID = universityID;
        }
    }
}
