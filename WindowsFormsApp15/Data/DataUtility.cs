using GangsOfCsharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DataUtility()
        {

        }
        private void initPaths()
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
        internal string getPath(Object o)
        {
            switch (o)
            {
                case University u:
                    return universitiesPath;
                case Course c:
                    return coursePath;
                case Major m:
                    return majorPath;
                case Rating r:
                    return ratingPath;
                case Student s:
                    return studentPath;
                default:
                    throw new ArgumentException(message: "Object does not match any of the storable" +
                        "Entities", paramName: o.ToString());
            }
        }
        internal string getPath(Type t)
        {
            Dictionary<Type, string> dic = new Dictionary<Type, string>
            {
                {typeof(University), universitiesPath },
                {typeof(Course), coursePath },
                {typeof(Lecturer), lecturerPath },
                {typeof(Major), majorPath },
                {typeof(Rating), ratingPath },
                {typeof(Student), studentPath }
            };
            return dic[t];
        }
    }
}
