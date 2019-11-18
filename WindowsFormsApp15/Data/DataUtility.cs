using System;
using System.Collections.Generic;
using System.IO;
using WindowsFormsApp15.model;

namespace WindowsFormsApp15.Data
{
    class DataUtility
    {
        private string coursePath;
        private string lecturerPath;
        private string majorPath;
        private string ratingPath;
        private string studentPath;
        private string universitiesPath;

        public string CoursePath { get => coursePath; }
        public string LecturerPath { get => lecturerPath; }
        public string MajorPath { get => majorPath; }
        public string RatingPath { get => ratingPath; }
        public string StudentPath { get => studentPath; }
        public string UniversitiesPath { get => universitiesPath; }

        public DataUtility()
        {
            InitPaths();
        }
        private void InitPaths()
        {
            string folder = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            coursePath = Path.Combine(folder, @"Data\", "CourseStorage.txt");
            lecturerPath = Path.Combine(folder, @"Data\", "LecturerStorage.txt");
            majorPath = Path.Combine(folder, @"Data\", "MajorStorage.txt");
            ratingPath = Path.Combine(folder, @"Data\", "RatingStorage.txt");
            studentPath = Path.Combine(folder, @"Data\", "StudentStorage.txt");
            universitiesPath = Path.Combine(folder, @"Data\", "UniversityStorage.txt");

        }

        /// <summary>
        /// Returns path where an Object should be stored.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        internal string GetPath(Object o)
        {
            switch (o)
            {
                case University u:
                    return UniversitiesPath;
                case Course c:
                    return coursePath;
                case Major m:
                    return MajorPath;
                case Rating r:
                    return RatingPath;
                case Student s:
                    return StudentPath;
                case Lecturer l:
                    return LecturerPath;
                default:
                    throw new ArgumentException(message: "Object does not match any of the storable" +
                        "Entities", paramName: o.ToString());
            }
        }
        internal string GetPath(Type t)
        {
            Dictionary<Type, string> dic = new Dictionary<Type, string>
            {
                {typeof(University), UniversitiesPath },
                {typeof(Course), CoursePath },
                {typeof(Lecturer), LecturerPath },
                {typeof(Major), MajorPath },
                {typeof(Rating), RatingPath },
                {typeof(Student), StudentPath }
            };
            return dic[t];
        }
    }
}
