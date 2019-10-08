using System; 
using System.Collections.Generic;

namespace WindowsFormsApp15.model
{
    public class University
    {
        private Guid universityID;
        private string universityName;

        /// <summary>
        /// Constructor for the class University without giving an ID.
        /// ID will be generated automatically.
        /// Should be used when creating a truly new object that is not yet stored.
        /// </summary>
        /// <param name="name">cannot be null</param>
        public University(string name)
        {
            WindowsFormsApp15.Data.DataSearch ds = new WindowsFormsApp15.Data.DataSearch();
            init(Guid.NewGuid(), name);
        }

        /// <summary>
        /// Constructs a new Entity of University from a line from the datafiles.
        /// Should only be used when creating objects from files!
        /// </summary>
        /// <param name="line"></param>
        public University(string[] line)
        {
            init(Guid.Parse(line[0]), line[1]);
        }

        public string UniversityName { get => universityName; }
        public Guid UniversityID { get => universityID; }

        private void init(Guid universityID, string name)
        {
            if (name == null)
                throw new ArgumentNullException("name cannot be null.");

            this.universityName = name;
            this.universityID = universityID;
        }

        /// <summary>
        /// Returns a string containing the objects properties in the format:
        /// "universityID;universityName".
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string info = UniversityID.ToString() + ";" +
                UniversityName + "\n";
            return info;
        }
    }
}
