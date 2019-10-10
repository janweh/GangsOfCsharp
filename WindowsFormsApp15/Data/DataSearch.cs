using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using WindowsFormsApp15.model;

namespace WindowsFormsApp15.Data
{
    class DataSearch
    {
        private string coursePath;
        private string lecturerPath;
        private string majorPath;
        private string ratingPath;
        private string studentPath;
        private string universitiesPath;

        private DataUtility du;
        public DataSearch()
        {
            //initializes all the paths to the folders which hold the data
            initPaths();
            du = new DataUtility();
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
        /// Finds the Object that matches the given ID in the Entitie's storage file.
        /// </summary>
        /// <typeparam name="T">The type of Object that should be returned</typeparam>
        /// <param name="id">The ID of the Object</param>
        /// <returns></returns>
        public T getByID<T>(Guid id)
            where T : class, new()
        {
            string path = du.getPath(typeof(T));
            Func<string[], bool> matches = (x) => x[0].Equals(id.ToString());
            List<string[]> matchingLines = getAllMatchingLines(matches, path);
            if (matchingLines.Count == 0)
            {
                throw new KeyNotFoundException("id did not match any id in the file.");
            }
            else if (matchingLines.Count != 1)
            {
                throw new DuplicateWaitObjectException("id occured multiple times in the file.");
            }
            return createNew<T>(matchingLines.First(), new T());
        }

        private T createNew<T>(string[] lines, Object o)
        {
            switch (o)
            {
                case University u:
                    u = new University(lines);
                    return (T)Convert.ChangeType(u, typeof(T));
                case Course c:
                    c = new Course(lines);
                    return (T)Convert.ChangeType(c, typeof(T));
                case Major m:
                    m = new Major(lines);
                    return (T)Convert.ChangeType(m, typeof(T));
                case Rating r:
                    r = new Rating(lines);
                    return (T)Convert.ChangeType(r, typeof(T));
                case Student s:
                    s = new Student(lines);
                    return (T)Convert.ChangeType(s, typeof(T));
                case Lecturer l:
                    l = new Lecturer(lines);
                    return (T)Convert.ChangeType(l, typeof(T));
                default:
                    throw new ArgumentException(message: "Object does not match any of the storable" +
                        "Entities", paramName: o.ToString());
            }
        }

        /// <summary>
        /// Return all Objects that are stored of that Entity.
        /// </summary>
        /// <typeparam name="T">Type of Objects that should be found.</typeparam>
        /// <returns></returns>
        public List<T> getAll<T>()
            where T : class, new()
        {
            List<T> ts = new List<T>();
            string path = du.getPath(typeof(T));
            Func<string[], bool> matches = (x) => true;
            List<string[]> matchingLines = getAllMatchingLines(matches, path);
            foreach(string[] r in matchingLines)
            {
                T t = createNew<T>(r, new T());
                ts.Add(t);
            }
            return ts;
        }

        /// <summary>
        /// Finds all universities which offer a certain major.
        /// </summary>
        /// <param name="major"></param>
        /// <returns></returns>
        public List<University> getUniversitiesWithMajor(Major major)
        {
            List<University> unis = new List<University>();
            Func<string[], bool> matches = (x) => x[1].Equals(major.Name);
            List<string[]> matchingLines = getAllMatchingLines(matches, majorPath);
            List<Guid> foundUnis = new List<Guid>();
            foreach(string[] r in matchingLines)
            {
                foundUnis.Add(Guid.Parse(r[2]));
            }
            foundUnis = foundUnis.Distinct().ToList();
            foreach(Guid uniID in foundUnis)
            {
                unis.Add(getByID<University>(uniID));
            }
            return unis;
        }

        /// <summary>
        /// Gets all the lecturers who teach at a certain university.
        /// </summary>
        /// <param name="university"></param>
        /// <returns></returns>
        public List<Lecturer> getLecturersFromUniversity(University university)
        {
            List<Lecturer> lecturers = new List<Lecturer>();
            Func<string[], bool> matches = (x) => x[2].Equals(university.UniversityID.ToString());
            List<string[]> matchingLines = getAllMatchingLines(matches, lecturerPath);
            foreach (string[] r in matchingLines)
            {
                Lecturer lecturer = new Lecturer(r);
                lecturers.Add(lecturer);
            }
            return lecturers;
        }

        /// <summary>
        /// Gets all the lecturers who teach a certain major.
        /// </summary>
        /// <param name="major"></param>
        /// <returns></returns>
        public List<Lecturer> getLecturersFromMajor(Major major)
        {
            List<Lecturer> lecturers = new List<Lecturer>();
            Func<string[], bool> matches = (x) => x[3].Equals(major.MajorID.ToString());
            List<string[]> matchingLines = getAllMatchingLines(matches, lecturerPath);
            foreach (string[] r in matchingLines)
            {
                Lecturer lecturer = new Lecturer(r);
                lecturers.Add(lecturer);
            }
            return lecturers;
        }
        
        /// <summary>
        /// Gets all the courses that match the keyword.
        /// Also includes courses where the keyword appears in the middle of the name (not only the ones
        /// where it occurs at the beginning).
        /// Is not case sensitive.
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<Course> getCoursesByKeyword(string keyword)
        {
            List<Course> courses = new List<Course>();
            //putting both strings as ToUpper() will make the search case insensitive
            Func<string[], bool> matches = (x) => x[1].ToUpper().Contains(keyword.ToUpper());
            List<string[]> matchingLines = getAllMatchingLines(matches, coursePath);
            foreach (string[] r in matchingLines)
            {
                Course course = new Course(r);
                courses.Add(course);
            }
            return courses;
        }

        /// <summary>
        /// Gets all the courses in this major
        /// </summary>
        /// <param name="major"></param>
        /// <returns></returns>
        public List<Course> getCoursesByMajor(Major major)
        {
            List<Course> courses = new List<Course>();
            Func<string[], bool> matches = (x) => x[5].Equals(major.MajorID.ToString());
            List<string[]> matchingLines = getAllMatchingLines(matches, coursePath);
            foreach (string[] r in matchingLines)
            {
                Course course = new Course(r);
                courses.Add(course);
            }
            return courses;
        }
        
        /// <summary>
        /// Gets all Courses that are held by this lecturer.
        /// </summary>
        /// <param name="lecturer"></param>
        /// <returns></returns>
        public List<Course> getCoursesByLecturer(Lecturer lecturer)
        {
            List<Course> courses = new List<Course>();
            Func<string[], bool> matches = (x) => x[3].Equals(lecturer.LecturerID.ToString());
            List<string[]> matchingLines = getAllMatchingLines(matches, coursePath);
            foreach (string[] r in matchingLines)
            {
                Course course = new Course(r);
                courses.Add(course);
            }
            return courses;
        }

        /// <summary>
        /// Gets all the ratings that were given for a certain course.
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public List<Rating> getRatingsByCourse(Course course)
        {
            List<Rating> ratings = new List<Rating>();
            Func<string[], bool> matches = (x) => x[2].Equals(course.CourseID.ToString());
            List<string[]> matchingLines = getAllMatchingLines(matches, ratingPath);
            foreach (string[] r in matchingLines)
            {
                Rating rating = new Rating(r);
                ratings.Add(rating);
            }
            return ratings;
        }

        /// <summary>
        /// Gets all the majors offered by a university by iterating thorgh MajorStorage file.
        /// </summary>
        /// <param name="university"></param>
        /// <returns>List of majors of the university</returns>
        public List<Major> getMajorsOfUniversity(University university)
        {
            List<Major> majors = new List<Major>();
            Func<string[], bool> matches = (x) => x[2].Equals(university.UniversityID.ToString());
            List<string[]> matchingLines = getAllMatchingLines(matches, majorPath);
            foreach (string[] r in matchingLines)
            {
                Major major = new Major(r);
                majors.Add(major);
            }
            return majors;
        }

        /// <summary>
        /// Calculates the average overallRating of the Course by iterating over all Ratings for the course.
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public double averageRatingForCourse(Course course)
        {
            double sum = 0;
            Func<string[], bool> matches = (x) => x[2].Equals(course.CourseID.ToString());
            List<string[]> matchingLines = getAllMatchingLines(matches, ratingPath);
            foreach (string[] r in matchingLines)
            {
                sum += Int32.Parse(r[4]);
            }
            return sum/matchingLines.Count;
        }

        /// <summary>
        /// Calculates the average overallRating of the courses in this major 
        /// by iterating over all courses and getting their average overallRating.
        /// </summary>
        /// <param name="major"></param>
        /// <returns></returns>
        public double averageRatingForMajor(Major major)
        {
            double sum = 0;
            List<Course> courses = getCoursesByMajor(major);
            foreach(Course course in courses)
            {
                sum += averageRatingForCourse(course);
            }
            return sum / courses.Count;
        }

        /// <summary>
        /// Calculates the average overallRating of the majors at this university
        /// by iterating over all majors and getting their average overallRating.
        /// </summary>
        /// <param name="university"></param>
        /// <returns></returns>
        public double averageRatingForUniversity(University university)
        {
            double sum = 0;
            List<Major> majors = getMajorsOfUniversity(university);
            foreach (Major major in majors)
            {
                sum += averageRatingForMajor(major);
            }
            return sum / majors.Count;
        }

        /// <summary>
        /// Calculates the average overallRating of the courses by this lecturer 
        /// by iterating over all courses and getting their average overallRating.
        /// </summary>
        /// <param name="lecturer"></param>
        /// <returns></returns>
        public double averageRatingForLecturer(Lecturer lecturer)
        {
            double sum = 0;
            List<Course> courses = getCoursesByLecturer(lecturer);
            foreach (Course course in courses)
            {
                sum += averageRatingForCourse(course);
            }
            return sum / courses.Count;
        }

        /// <summary>
        /// Returns the average overallRating of all courses in this major, the amount
        /// of courses in this major and the amount of lecturers in this major;
        /// Should only be used by UniSearchWindow!!!
        /// </summary>
        /// <param name="major"></param>
        /// <returns></returns>
        public Tuple<double, int, int> averageRatingAmountCoursesAmountLecturersForMajor(Major major)
        {
            double sumCourses = 0;
            List<Course> courses = getCoursesByMajor(major);
            foreach (Course course in courses)
            {
                sumCourses += averageRatingForCourse(course);
            }

            Func<string[], bool> matches = (x) => x[3].Equals(major.MajorID.ToString());
            int foundLecturers = getNumberOfMatchingLines(matches, lecturerPath);

            return new Tuple<double, int, int>(sumCourses/courses.Count, courses.Count, foundLecturers);
        }

        /// <summary>
        /// Returns the average overallRating of this course and the amount of ratings the course has.
        /// Should only be used by ProfessorSearchResultWindow and CoursewSearchResultWindow!!!
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public Tuple<double, int> averageRatingAmountRatingsForCourse(Course course)
        {
            double sum = 0;
            Func<string[], bool> matches = (x) => x[2].Equals(course.CourseID.ToString());
            List<string[]> matchingLines = getAllMatchingLines(matches, ratingPath);
            foreach (string[] r in matchingLines)
            {
                sum += Int32.Parse(r[4]);
            }
            return new Tuple<double, int>(sum / matchingLines.Count, matchingLines.Count);
        }

        /// <summary>
        /// Calculates the average overallRating of all courses at the university, as well as the
        /// number of professors teaching there and the amount of courses and majors offered.
        /// Should only be used by MajorSearchResultWindow!!!
        /// </summary>
        /// <param name="university"></param>
        /// <returns></returns>
        public Tuple<double, int, int, int> averageRatingAmountCoursesMajorsProfessors(University university)
        {
            Func<string[], bool> matchesMajor = (x) => x[2].Equals(university.UniversityID.ToString());
            List<string[]> matchingMajors = getAllMatchingLines(matchesMajor, majorPath);

            Func<string[], bool> matchesProfessor = (x) => x[2].Equals(university.UniversityID.ToString());
            int amountProfessors = getNumberOfMatchingLines(matchesProfessor, lecturerPath);
            double ratingSum = 0;
            int countRatings = 0;
            int countCourses = 0;
            foreach(string[] major in matchingMajors)
            {
                Func<string[], bool> matchesCourse = (x) => x[2].Equals(major);
                List<string[]> matchingCourses = getAllMatchingLines(matchesCourse, coursePath);
                countCourses += matchingCourses.Count;
                foreach(string[] course in matchingCourses)
                {
                    Func<string[], bool> matchesRating = (x) => x[2].Equals(course[0]);
                    List<string[]> matchingRatings = getAllMatchingLines(matchesRating, ratingPath);
                    countRatings += matchingRatings.Count;
                    foreach(string[] rating in matchingRatings)
                    {
                        ratingSum += Int32.Parse(rating[4]);
                    }
                }
            }
            return new Tuple<double, int, int, int>(ratingSum/countRatings ,countCourses , 
                matchingMajors.Count, amountProfessors);
        }

        private List<string[]> getAllMatchingLines(Func<string[], bool> match, string path)
        {
            List<string[]> results = new List<string[]>();
            using (StreamReader sr = File.OpenText(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(';');
                    if (match(splitLine))
                        results.Add(splitLine);

                }
            }
            return results;
        }

        private int getNumberOfMatchingLines(Func<string[], bool> match, string path)
        {
            int number = 0;
            using (StreamReader sr = File.OpenText(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(';');
                    if (match(splitLine))
                        number++;

                }
            }
            return number;
        }
    }
}
