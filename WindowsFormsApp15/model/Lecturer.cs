using System;
using WindowsFormsApp15.Data;

namespace WindowsFormsApp15.model
{
    public class Lecturer : Storable
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
            Init(Guid.NewGuid(), titleAndName, university, major);
        }

        /// <summary>
        /// Constructs a new Entity of Lecturer from a line from the datafiles.
        /// Should only be used when creating objects from files!
        /// </summary>
        /// <param name="line"></param>
        public Lecturer(string[] line)
        {
            DataSearch ds = new DataSearch();
            University u;
            try
            {
                u = ds.GetByID<University>(Guid.Parse(line[2]));
            }
            catch (DuplicateDataException)
            {
                u = new University();
            }
            Major m;
            try
            {
                m = ds.GetByID<Major>(Guid.Parse(line[5]));
            }
            catch (DuplicateDataException)
            {
                m = new Major();
            }
            Init(Guid.Parse(line[0]), line[1], u, m);
        }

        public University University { get => university; }
        public override Guid ID { get => lecturerID; }
        public string TitleAndName { get => titleAndName; }
        public Major Major { get => major; }

        public void SetUniversity(University university)
        {
            this.university = university ?? throw new ArgumentNullException("university cannot be null.");
        }

        private void Init(Guid lecturerID, string titleAndName, University university, Major major)
        {
            this.lecturerID = lecturerID;
            this.titleAndName = titleAndName ?? throw new ArgumentNullException("titleAndName cannot be null.");
            this.university = university ?? throw new ArgumentNullException("university cannot be null.");
            this.major = major ?? throw new ArgumentNullException("major cannot be null.");
        }

        /// <summary>
        /// Returns a String describing the Objects properties in the format:
        /// "lecturerID;titleAndName;universityID;majorID".
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string info = ID.ToString() + ";" +
                TitleAndName + ";" +
                University.ID.ToString() + ";" +
                Major.ID.ToString() + "\n";
            return info;
        }

        public Lecturer() : base() { }
    }
}
