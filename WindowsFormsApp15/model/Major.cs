using GangsOfCsharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.model;

namespace GangsOfCsharp
{
    public class Major
    {
        private University university;
        private int majorID;
        private string majorName;

        /// <summary>
        /// Constructor for the class Major without giving a majorID.
        /// ID will be generated automatically.
        /// Should be used when creating a truly new object that is not yet stored.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="university"></param>
        public Major(string name, University university)
        {
            DataSearch ds = new DataSearch();
            init(ds.getNextMajorID(), name, university);
        }

        /// <summary>
        /// Constructor for the class Major with manually assigning the majorID.
        /// Should be used when recreating an object from the datafile
        /// </summary>
        /// <param name="majorID"></param>
        /// <param name="name"></param>
        /// <param name="university"></param>
        public Major(int majorID, string name, University university)
        {
            init(majorID, name, university);
        }

        public int MajorID { get => majorID; }
        public string Name { get => majorName; }
        public University University { get => university; }

        private void init(int majorID, string name, University university)
        {
            if (university == null)
                throw new ArgumentNullException("university cannot be null!");
            if (name == null)
                throw new ArgumentNullException("name cannot be null!");

            this.majorName = name;
            this.majorID = majorID;
            this.university = university;
        }
    }
}
