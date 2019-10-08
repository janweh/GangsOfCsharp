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
        private Guid majorID;
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
            init(Guid.NewGuid(), name, university);
        }

        /// <summary>
        /// Constructs a new Entity of Major from a line from the datafiles.
        /// Should only be used when creating objects from files!
        /// </summary>
        /// <param name="line"></param>
        public Major(string[] line)
        {
            DataSearch ds = new DataSearch();
            init(Guid.Parse(line[0]), line[1], ds.getByID<University>(Guid.Parse(line[2]))); ;
        }

        public Guid MajorID { get => majorID; }
        public string Name { get => majorName; }
        public University University { get => university; }

        private void init(Guid majorID, string name, University university)
        {
            if (university == null)
                throw new ArgumentNullException("university cannot be null!");
            if (name == null)
                throw new ArgumentNullException("name cannot be null!");

            this.majorName = name;
            this.majorID = majorID;
            this.university = university;
        }

        /// <summary>
        /// Return a string with the objects properties in the format:
        /// "majorID;majorName;universityID".
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string info = MajorID.ToString() + ";" +
                Name + ";" +
                University.UniversityID.ToString() + "\n";
            return info;
        }
    }
}
