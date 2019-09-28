using GangsOfCsharp;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;

namespace WindowsFormsApp15.model
{
    class DataSearch
    {
        private string coursePath;
        private string lecturerPath;
        private string majorPath;
        private string ratingPath;
        private string studentPath;
        private string universitiesPath;
        public DataSearch()
        {
            //initializes all the paths to the folders which hold the data
            string folder = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            coursePath = Path.Combine(folder, @"Data\", "CourseStorage.txt");
            lecturerPath = Path.Combine(folder, @"Data\", "LecturerStorage.txt");
            majorPath = Path.Combine(folder, @"Data\", "MajorStorage.txt");
            ratingPath = Path.Combine(folder, @"Data\", "RatingStorage.txt");
            studentPath = Path.Combine(folder, @"Data\", "StudentStorage.txt");
            universitiesPath = Path.Combine(folder, @"Data\", "UniversityStorage.txt");
        }


        ////////////////////////////////UNIVERSITY////////////////////////////////

        /// <summary>
        /// Stores the university in a file with all the other universities.
        /// Format of storage: "universityID;universityName"
        /// </summary>
        /// <param name="university"></param>
        /// <exception cref="ArgumentException">universityID allready exists in the file.</exception>
        public void store(University university)
        {
            checkDuplicateID(university);
            string info = university.UniversityID.ToString() + ";" + 
                university.UniversityName + "\n";
            File.AppendAllText(universitiesPath, info);
        }

        private void checkDuplicateID(University university)
        {
            using(StreamReader sr = File.OpenText(universitiesPath))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    if (parts[0].Equals(university.UniversityID.ToString()))
                        throw new ArgumentException("this universityID is allready used!");
                }
            }
        }

        /// <summary>
        /// Finds the University with the given id by iterating through the UniversityStorage file.
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="KeyNotFoundException">id does not match any of the universityIDs in the file</exception>
        /// <exception cref="DuplicateWaitObjectException">the id occurs multiple times</exception>
        /// <returns>the university with the given ID</returns>
        public University getUniversityByID(int id)
        {
            Func<string[], bool> matches = (x) => x[0].Equals(id.ToString());
            List<string[]> matchingLines = getAllMatchingLines(matches, universitiesPath);
            if(matchingLines.Count == 0)
            {
                throw new KeyNotFoundException("id did not match any universityID in the file.");
            } else if(matchingLines.Count != 1)
            {
                throw new DuplicateWaitObjectException("id occured multiple times in the file.");
            }
            string[] r = matchingLines.First();
            University university = new University(Int32.Parse(r[0]), r[1]);
            return university;
        }

        /// <summary>
        /// Returns all stored universities
        /// </summary>
        /// <returns>All universities in the UniversityStorage file</returns>
        public List<University> getAllUniversities()
        {
            List<University> unis = new List<University>();
            Func<string[], bool> matches = (x) => true;
            List<string[]> matchingLines = getAllMatchingLines(matches, universitiesPath);
            foreach(string[] r in matchingLines)
            {
                University uni = new University(Int32.Parse(r[0]), r[1]);
                unis.Add(uni);
            }
            return unis;
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
            List<int> foundUnis = new List<int>();
            foreach(string[] r in matchingLines)
            {
                foundUnis.Add(Int32.Parse(r[2]));
            }
            foundUnis = foundUnis.Distinct().ToList();
            foreach(int uniID in foundUnis)
            {
                unis.Add(getUniversityByID(uniID));
            }
            return unis;
        }

        /// <summary>
        /// Finds and returns the next free ID in the datafile.
        /// If there are no files yet it will return 1;
        /// </summary>
        /// <returns></returns>
        public int getNextUniversityID()
        {
            return findID(universitiesPath);
        }



        ////////////////////////////////LECTURER////////////////////////////////

        /// <summary>
        /// Stores the lecturer in a file with all the other lecturers.
        /// Format of storage: "lecturerID;titleAndName;universityID;majorID"
        /// </summary>
        /// <param name="lecturer"></param>
        /// <exception cref="ArgumentException">lecturerID allready exists in the file.</exception>
        public void store(Lecturer lecturer)
        {
            checkDuplicateID(lecturer);
            string info = lecturer.LecturerID.ToString() + ";" +
                lecturer.TitleAndName + ";" +
                lecturer.University.UniversityID.ToString() + ";" +
                lecturer.Major.MajorID.ToString() + "\n";
            File.AppendAllText(lecturerPath, info);
        }

        private void checkDuplicateID(Lecturer lecturer)
        {
            using (StreamReader sr = File.OpenText(lecturerPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    if (parts[0].Equals(lecturer.LecturerID.ToString()))
                        throw new ArgumentException("this lecturerID is allready used!");
                }
            }
        }

        /// <summary>
        /// Finds the lecturer with the given id by iterating through the LecturerStorage file.
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="KeyNotFoundException">id does not match any of the lecturerIDs in the file</exception>
        /// <exception cref="DuplicateWaitObjectException">the id occurs multiple times</exception>
        /// <returns>the lecturer with the given ID</returns>
        public Lecturer getLecturerByID(int id)
        {
            Func<string[], bool> matches = (x) => x[0].Equals(id.ToString());
            List<string[]> matchingLines = getAllMatchingLines(matches, lecturerPath);
            if (matchingLines.Count == 0)
            {
                throw new KeyNotFoundException("id did not match any lecturerID in the file.");
            }
            else if (matchingLines.Count != 1)
            {
                throw new DuplicateWaitObjectException("id occured multiple times in the file.");
            }
            string[] r = matchingLines.First();
            Lecturer lecturer = new Lecturer(Int32.Parse(r[0]), r[1], getUniversityByID(Int32.Parse(r[2])), 
                getMajorByID(Int32.Parse(r[3])));
            return lecturer;
        }

        /// <summary>
        /// Returns all stored lecturers
        /// </summary>
        /// <returns>All lecturers in the LecturerStorage file</returns>
        public List<Lecturer> getAllLecturers()
        {
            List<Lecturer> lecturers = new List<Lecturer>();
            Func<string[], bool> matches = (x) => true;
            List<string[]> matchingLines = getAllMatchingLines(matches, lecturerPath);
            foreach (string[] r in matchingLines)
            {
                Lecturer lecturer = new Lecturer(Int32.Parse(r[0]), r[1], getUniversityByID(Int32.Parse(r[2])),
                    getMajorByID(Int32.Parse(r[3])));
                lecturers.Add(lecturer);
            }
            return lecturers;
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
                Lecturer lecturer = new Lecturer(Int32.Parse(r[0]), r[1], university, getMajorByID(Int32.Parse(r[3])));
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
                Lecturer lecturer = new Lecturer(Int32.Parse(r[0]), r[1], getUniversityByID(Int32.Parse(r[2])), 
                    major);
                lecturers.Add(lecturer);
            }
            return lecturers;
        }

        /// <summary>
        /// Finds and returns the next free ID in the datafile.
        /// If there are no files yet it will return 1;
        /// </summary>
        /// <returns></returns>
        public int getNextLecturerID()
        {
            return findID(lecturerPath);
        }



        ////////////////////////////////COURSE////////////////////////////////

        /// <summary>
        /// Stores the course in a file with all the other courses.
        /// Format of storage: "courseID;courseName;universityID;majorID;lecturerID;since"
        /// </summary>
        /// <param name="course"></param>
        /// <exception cref="ArgumentException">courseID allready exists in the file.</exception>
        public void store(Course course)
        {
            checkDuplicateID(course);
            string info = course.CourseID.ToString() + ";" +
                course.Name + ";" +
                course.University.UniversityID.ToString() + ";" +
                course.Lecturer.LecturerID.ToString() + ";" +
                course.Since + ";" +
                course.Major.MajorID.ToString() + "\n";
            File.AppendAllText(coursePath, info);
        }

        private void checkDuplicateID(Course course)
        {
            using (StreamReader sr = File.OpenText(coursePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    if (parts[0].Equals(course.CourseID.ToString()))
                        throw new ArgumentException("this courseID is allready used!");
                }
            }
        }

        /// <summary>
        /// Finds the course with the given id by iterating through the CourseStorage file.
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="KeyNotFoundException">id does not match any of the courseIDs in the file</exception>
        /// <exception cref="DuplicateWaitObjectException">the id occurs multiple times</exception>
        /// <returns>the course with the given ID</returns>
        public Course getCourseByID(int id)
        {
            Func<string[], bool> matches = (x) => x[0].Equals(id.ToString());
            List<string[]> matchingLines = getAllMatchingLines(matches, coursePath);
            if (matchingLines.Count == 0)
            {
                throw new KeyNotFoundException("id did not match any courseID in the file.");
            }
            else if (matchingLines.Count != 1)
            {
                throw new DuplicateWaitObjectException("id occured multiple times in the file.");
            }
            string[] r = matchingLines.First();
            Course course = new Course(Int32.Parse(r[0]), r[1], getUniversityByID(Int32.Parse(r[2])),
                getLecturerByID(Int32.Parse(r[3])), r[4], getMajorByID(Int32.Parse(r[5])));
            return course;
        }

        /// <summary>
        /// Returns all stored courses
        /// </summary>
        /// <returns>All courses in the courseStorage file</returns>
        public List<Course> getAllCourses()
        {
            List<Course> courses = new List<Course>();
            Func<string[], bool> matches = (x) => true;
            List<string[]> matchingLines = getAllMatchingLines(matches, coursePath);
            foreach (string[] r in matchingLines)
            {
                Course course = new Course(Int32.Parse(r[0]), r[1], getUniversityByID(Int32.Parse(r[2])),
                    getLecturerByID(Int32.Parse(r[3])), r[4], getMajorByID(Int32.Parse(r[5])));
                courses.Add(course);
            }
            return courses;
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
                Course course = new Course(Int32.Parse(r[0]), r[1], getUniversityByID(Int32.Parse(r[2])),
                    getLecturerByID(Int32.Parse(r[3])), r[4], getMajorByID(Int32.Parse(r[5])));
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
                Course course = new Course(Int32.Parse(r[0]), r[1], getUniversityByID(Int32.Parse(r[2])),
                    getLecturerByID(Int32.Parse(r[3])), r[4], getMajorByID(Int32.Parse(r[5])));
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
                Course course = new Course(Int32.Parse(r[0]), r[1], getUniversityByID(Int32.Parse(r[2])),
                    getLecturerByID(Int32.Parse(r[3])), r[4], getMajorByID(Int32.Parse(r[5])));
                courses.Add(course);
            }
            return courses;
        }

        /// <summary>
        /// Finds and returns the next free ID in the datafile.
        /// If there are no files yet it will return 1;
        /// </summary>
        /// <returns></returns>
        public int getNextCourseID()
        {
            return findID(coursePath);
        }



        ////////////////////////////////RATING////////////////////////////////

        /// <summary>
        /// Stores the rating in a file with all the other ratings.
        /// Format of storage: "ratingID;studentID;courseID;ratedSemester;overallRating;
        /// contactHours;selfStudyHours;organized;learned;interesting;
        /// presentation;comment"
        /// </summary>
        /// <param name="rating"></param>
        /// <exception cref="ArgumentException">ratingID allready exists in the file.</exception>
        public void store(Rating rating)
        {
            checkDuplicateID(rating);
            string info = rating.RatingID.ToString() + ";" +
                rating.Student.StudentID.ToString() + ";" +
                rating.Course.CourseID.ToString() + ";" +
                rating.Semester + ";" +
                rating.OverallRating.ToString() + ";" +
                rating.ContactHours.ToString() + ";" +
                rating.SelfStudyHours.ToString() + ";" +
                rating.Organized.ToString() + ";" +
                rating.Learned.ToString() + ";" +
                rating.Interesting.ToString() + ";" +
                rating.Presentation.ToString() + ";" +
                rating.Comment + "\n";
                File.AppendAllText(ratingPath, info);
        }

        private void checkDuplicateID(Rating rating)
        {
            using (StreamReader sr = File.OpenText(ratingPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    if (parts[0].Equals(rating.RatingID.ToString()))
                        throw new ArgumentException("this ratingID is allready used!");
                }
            }
        }

        /// <summary>
        /// Finds the rating with the given id by iterating through the RatingStorage file.
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="KeyNotFoundException">id does not match any of the ratingIDs in the file</exception>
        /// <exception cref="DuplicateWaitObjectException">the id occurs multiple times</exception>
        /// <returns>the rating with the given ID</returns>
        public Rating getRatingByID(int id)
        {
            Func<string[], bool> matches = (x) => x[0].Equals(id.ToString());
            List<string[]> matchingLines = getAllMatchingLines(matches, ratingPath);
            if (matchingLines.Count == 0)
            {
                throw new KeyNotFoundException("id did not match any ratingID in the file.");
            }
            else if (matchingLines.Count != 1)
            {
                throw new DuplicateWaitObjectException("id occured multiple times in the file.");
            }
            string[] r = matchingLines.First();
            Rating rating = new Rating(Int32.Parse(r[0]), getStudentByID(Int32.Parse(r[1])), 
                getCourseByID(Int32.Parse(r[2])), r[3], Int32.Parse(r[4]), Int32.Parse(r[5]), 
                Int32.Parse(r[6]), Int32.Parse(r[7]), Int32.Parse(r[8]), Int32.Parse(r[9]), 
                Int32.Parse(r[10]), r[11]);
            return rating;
        }

        /// <summary>
        /// Returns all stored ratings
        /// </summary>
        /// <returns>All ratings in the RatingStorage file</returns>
        public List<Rating> getAllRatings()
        {
            List<Rating> ratings = new List<Rating>();
            Func<string[], bool> matches = (x) => true;
            List<string[]> matchingLines = getAllMatchingLines(matches, ratingPath);
            foreach (string[] r in matchingLines)
            {
                Rating rating = new Rating(Int32.Parse(r[0]), getStudentByID(Int32.Parse(r[1])),
                getCourseByID(Int32.Parse(r[2])), r[3], Int32.Parse(r[4]), Int32.Parse(r[5]),
                Int32.Parse(r[6]), Int32.Parse(r[7]), Int32.Parse(r[8]), Int32.Parse(r[9]),
                Int32.Parse(r[10]), r[11]);
                ratings.Add(rating);
            }
            return ratings;
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
                Rating rating = new Rating(Int32.Parse(r[0]), getStudentByID(Int32.Parse(r[1])),
                getCourseByID(Int32.Parse(r[2])), r[3], Int32.Parse(r[4]), Int32.Parse(r[5]),
                Int32.Parse(r[6]), Int32.Parse(r[7]), Int32.Parse(r[8]), Int32.Parse(r[9]),
                Int32.Parse(r[10]), r[11]);
                ratings.Add(rating);
            }
            return ratings;
        }

        /// <summary>
        /// Finds and returns the next free ID in the datafile.
        /// If there are no files yet it will return 1;
        /// </summary>
        /// <returns></returns>
        public int getNextRatingID()
        {
            return findID(ratingPath);
        }



        ////////////////////////////////STUDENT////////////////////////////////

        /// <summary>
        /// Stores the student in a file with all the other students.
        /// Format of storage: "studentID;universityID;majorID;studentName;
        /// userName;password;areaOfStudies;currentSemester"
        /// </summary>
        /// <param name="student"></param>
        /// <exception cref="ArgumentException">studentID allready exists in the file.</exception>
        public void store(Student student)
        {
            checkDuplicateID(student);
            string info = student.StudentID.ToString() + ";" +
                student.UserName + ";" +
                student.Password + ";" +
                student.StudentName + ";" +
                student.University.UniversityID.ToString() + ";" +
                student.Major.MajorID.ToString() + ";" +
                student.AreaOfStudies + ";" +
                student.Semester.ToString() +"\n";
            File.AppendAllText(studentPath, info);
        }

        private void checkDuplicateID(Student student)
        {
            using (StreamReader sr = File.OpenText(studentPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    if (parts[0].Equals(student.StudentID.ToString()))
                        throw new ArgumentException("this studentID is allready used!");
                }
            }
        }

        /// <summary>
        /// Finds the student with the given id by iterating through the StudentStorage file.
        /// Should be used when creating a truly new object that is not yet stored.
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="KeyNotFoundException">id does not match any of the studentIDs in the file</exception>
        /// <exception cref="DuplicateWaitObjectException">the id occurs multiple times</exception>
        /// <returns>the student with the given ID</returns>
        public Student getStudentByID(int id)
        {
            Func<string[], bool> matches = (x) => x[0].Equals(id.ToString());
            List<string[]> matchingLines = getAllMatchingLines(matches, studentPath);
            if (matchingLines.Count == 0)
            {
                throw new KeyNotFoundException("id did not match any studentID in the file.");
            }
            else if (matchingLines.Count != 1)
            {
                throw new DuplicateWaitObjectException("id occured multiple times in the file.");
            }
            string[] r = matchingLines.First();
            Student student = new Student(Int32.Parse(r[0]), r[1], r[2], r[3], getUniversityByID(Int32.Parse(r[4])), 
                getMajorByID(Int32.Parse(r[5])), r[6], Int32.Parse(r[7]));
            return student;
        }

        /// <summary>
        /// Returns all stored students
        /// </summary>
        /// <returns>All students in the studentStorage file</returns>
        public List<Student> getAllStudents()
        {
            List<Student> students = new List<Student>();
            Func<string[], bool> matches = (x) => true;
            List<string[]> matchingLines = getAllMatchingLines(matches, studentPath);
            foreach (string[] r in matchingLines)
            {
                Student student = new Student(Int32.Parse(r[0]), r[1], r[2], r[3], getUniversityByID(Int32.Parse(r[4])),
                getMajorByID(Int32.Parse(r[5])), r[6], Int32.Parse(r[7]));
                students.Add(student);
            }
            return students;
        }

        /// <summary>
        /// Finds and returns the next free ID in the datafile.
        /// If there are no files yet it will return 1;
        /// </summary>
        /// <returns></returns>
        public int getNextStudentID()
        {
            return findID(studentPath);
        }



        ////////////////////////////////MAJOR////////////////////////////////

        /// <summary>
        /// Stores the major in a file with all the other majors.
        /// Format of storage: "majorID;majorName;universityID"
        /// </summary>
        /// <param name="major"></param>
        /// <exception cref="ArgumentException">majorID allready exists in the file.</exception>
        public void store(Major major)
        {
            checkDuplicateID(major);
            string info = major.MajorID.ToString() + ";" +
                major.Name + ";"  +
                major.University.UniversityID.ToString() + "\n";
            File.AppendAllText(majorPath, info);
        }

        private void checkDuplicateID(Major major)
        {
            using (StreamReader sr = File.OpenText(majorPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    if (parts[0].Equals(major.MajorID.ToString()))
                        throw new ArgumentException("this majorID is allready used!");
                }
            }
        }

        /// <summary>
        /// Finds the major with the given id by iterating through the MajorStorage file.
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="KeyNotFoundException">id does not match any of the majorIDs in the file</exception>
        /// <exception cref="DuplicateWaitObjectException">the id occurs multiple times</exception>
        /// <returns>the major with the given ID</returns>
        public Major getMajorByID(int id)
        {
            Func<string[], bool> matches = (x) => x[0].Equals(id.ToString());
            List<string[]> matchingLines = getAllMatchingLines(matches, majorPath);
            if (matchingLines.Count == 0)
            {
                throw new KeyNotFoundException("id did not match any majorID in the file.");
            }
            else if (matchingLines.Count != 1)
            {
                throw new DuplicateWaitObjectException("id occured multiple times in the file.");
            }
            string[] r = matchingLines.First();
            Major major = new Major(Int32.Parse(r[0]), r[1], getUniversityByID(Int32.Parse(r[2])));
            return major;
        }

        /// <summary>
        /// Returns all stored majors
        /// </summary>
        /// <returns>All majors in the majorStorage file</returns>
        public List<Major> getAllMajors()
        {
            List<Major> majors = new List<Major>();
            Func<string[], bool> matches = (x) => true;
            List<string[]> matchingLines = getAllMatchingLines(matches, majorPath);
            foreach (string[] r in matchingLines)
            {
                Major major = new Major(Int32.Parse(r[0]), r[1], getUniversityByID(Int32.Parse(r[2])));
                majors.Add(major);
            }
            return majors;
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
                Major major = new Major(Int32.Parse(r[0]), r[1], university);
                majors.Add(major);
            }
            return majors;
        }

        /// <summary>
        /// Finds and returns the next free ID in the datafile.
        /// If there are no files yet it will return 1;
        /// </summary>
        /// <returns></returns>
        public int getNextMajorID()
        {
            return findID(majorPath );
        }





        //this is old code but i left it in there because we may need it when we create a database
        /*public void Initialize()
        {
            SQLiteConnection.CreateFile("MyDatabase.sqlite");
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            string sql = "create table courses (courseID int, name varchar(150), " +
                "universityID int, lecturerID int, since varchar(10), numberOfRatings int)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            string sql1 = "insert into courses (courseID int, name varchar(150), " +
                "universityID int, lecturerID int, since varchar(10)) " +
                "values (1, AOOP, 1, 1, SS18, 5)";
            command = new SQLiteCommand(sql1, m_dbConnection);
            command.ExecuteNonQuery();
            sql = "select * from courses";
            command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while(reader.Read())
                Console.WriteLine("courseID: " + reader["courseID"] + 
                    "\tName: " + reader["name"] + 
                    "\tUni: " + reader["universityID"] + 
                    "\tLecturer: " + reader["lecturerID"] + 
                    "\tSince: " + reader["since"]);

            m_dbConnection.Close();

        }*/

        public object[] UniversityNameSearch()
        {
            return new object[] {
            "Vilnius University",
            "Istanbul University",
            "Vilnius Gediminas Technical University",
            "Bogazici University",
            "Middle East Technical University",
            "Munich Technical University",
            "Berlin Technical University",
            "Heidelberg University"};
        }

        public double CalculateAverageRatingForUniversity(University uni)
        {
            return 4.5;
        }

        public double CalculateAverageRatingForMajor(Major major)
        {
            return 4.5;
        }
        public double CalculateAverageRatingForLecturer(Lecturer lecturer)
        {
            //iterate through all courses with this lecturer and calculate average
            return 4.5;
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

        private int findID(string path)
        {
            int newID = 1;
            using (StreamReader sr = File.OpenText(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(';');
                    int oldID = Int32.Parse(splitLine[0]);
                    if (oldID >= newID)
                        newID = oldID + 1;
                }
            }
            return newID;
        }
    }
}
