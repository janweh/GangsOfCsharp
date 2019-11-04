﻿using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsApp15.Data;

namespace WindowsFormsApp15.model
{
    public class Rating
    {
        private Guid ratingID;
        private Student student;
        private Course course;


        private Semester semester;
        /// <summary>
        /// score from 1-5
        /// </summary>
        private int overallRating;
        private int contactHours;
        private int selfStudyHours;
        /// <summary>
        /// score from 1-5
        /// </summary>
        private int organized;
        /// <summary>
        /// score from 1-5
        /// </summary>
        private int learned;
        /// <summary>
        /// score from 1-5
        /// </summary>
        private int interesting;
        /// <summary>
        /// score from 1-5
        /// </summary>
        private int presentation;
        private string comment;
        private DateTime date;

        private DataSearch ds;

        /// <summary>
        /// Constructor for the class Rating without giving a ratingID.
        /// ID will be generated automatically.
        /// Should be used when creating a truly new object that is not yet stored.
        /// </summary>
        /// <param name="student">cannot be null</param>
        /// <param name="course">cannot be null</param>
        /// <param name="semester">cannot be null</param>
        /// <param name="overallRating">Number between 1-10. can be null</param>
        /// <param name="contactHours">Positive number. can be null</param>
        /// <param name="selfStudyHours">Positive number. can be null</param>
        /// <param name="organized">Number bewteesn 1-5. can be null</param>
        /// <param name="learned">Number between 1-5. can be null</param>
        /// <param name="interesting">Number between 1-5. can be null</param>
        /// <param name="presentation">Number bewteen 1-5. can be null</param>
        /// <param name="comment">Number between 1-5. can be null</param>
        /// <param name="date"></param>
        public Rating(Student student, Course course,
            Semester semester, int overallRating, int contactHours, int selfStudyHours, int organized,
            int learned, int interesting, int presentation, string comment, DateTime date)
        {
            ds = new DataSearch();

            DataSearch.Matches condition = (x) => (x[1].Equals(student.StudentID.ToString()) &&
                x[2].Equals(course.CourseID.ToString()));
            if (ds.ObjectExists<Rating>(condition))
            {
                throw new DuplicateDataException("This student has already given a Rating to this course!");
            }
            init(Guid.NewGuid(), student, course, semester, overallRating, contactHours, selfStudyHours,
                organized, learned, interesting, presentation, comment, date);
        }

        /// <summary>
        /// Constructs a new Entity of Rating from a line from the datafiles.
        /// Should only be used when creating objects from files!
        /// </summary>
        /// <param name="line"></param>
        public Rating(string[] r)
        {
            ds = new DataSearch();
            init(Guid.Parse(r[0]), ds.GetByID<Student>(Guid.Parse(r[1])),
                ds.GetByID<Course>(Guid.Parse(r[2])), EnumTranslator.stringToSemester[r[3]],
                Int32.Parse(r[4]), Int32.Parse(r[5]), Int32.Parse(r[6]), Int32.Parse(r[7]),
                Int32.Parse(r[8]), Int32.Parse(r[9]), Int32.Parse(r[10]), r[11],
                DateTime.Parse(r[12]));
        }

        public Semester Semester { get => semester; set => semester = value; }
        public int OverallRating { get => overallRating; set => overallRating = value; }
        public int ContactHours { get => contactHours; set => contactHours = value; }
        public int SelfStudyHours { get => selfStudyHours; set => selfStudyHours = value; }
        public int Organized { get => organized; set => organized = value; }
        public int Learned { get => learned; set => learned = value; }
        public int Interesting { get => interesting; set => interesting = value; }
        public int Presentation { get => presentation; set => presentation = value; }
        public string Comment { get => comment; set => comment = value; }
        public Student Student { get => student; }
        public void SetStudent(Student student)
        {
            this.student = student ?? throw new ArgumentNullException("student cannot be null.");
        }
        public Course Course { get => course; }
        public Guid RatingID { get => ratingID; }
        public DateTime Date { get => date; }
        public void SetCourse(Course course)
        {
            this.course = course ?? throw new ArgumentNullException("course cannot be null.");
        }

        private void init(Guid ratingID, Student student, Course course,
            Semester semester, int overallRating, int contactHours, int selfStudyHours, int organized,
            int learned, int interesting, int presentation, string comment, DateTime date)
        {
            if (student == null) { throw new ArgumentNullException("student cannot be null"); }

            if (course == null) { throw new ArgumentNullException("course cannot be null"); }

            if (overallRating < 1 || overallRating > 5) { throw new ArgumentException("overallRating has to be between 1-10."); }
            if (contactHours < 0) { throw new ArgumentException("contactHours has to be positive"); }
            if (selfStudyHours < 0) { throw new ArgumentException("selfStudyHours has to be positive"); }
            if (organized < 1 || organized > 5) { throw new ArgumentException("organized has to be between 1-5"); }
            if (learned < 1 || learned > 5) { throw new ArgumentException("learned has to be between 1-5"); }
            if (interesting < 1 || interesting > 5) { throw new ArgumentException("interesting has to be between 1-5"); }
            if (presentation < 1 || presentation > 5) { throw new ArgumentException("presentation has to be between 1-5"); }
            if (semester.CompareTo(course.Since) > 0)
            {
                throw new ArgumentException(
"the semester the course was taken in can not be later than since when the course exists");
            }



            this.ratingID = ratingID;
            this.student = student ?? throw new ArgumentNullException("student cannot be null");
            this.course = course;
            this.semester = semester;
            this.overallRating = overallRating;
            this.contactHours = contactHours;
            this.selfStudyHours = selfStudyHours;
            this.organized = organized;
            this.learned = learned;
            this.interesting = interesting;
            this.presentation = presentation;
            this.comment = comment;
            this.date = date;
        }

        /// <summary>
        /// Returns a string containing the objects properties in the format:
        /// "ratingID;studentID;courseID;ratedSemester;overallRating;
        /// contactHours;selfStudyHours;organized;learned;interesting;
        /// presentation;comment"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string info = RatingID.ToString() + ";" +
                Student.StudentID.ToString() + ";" +
                Course.CourseID.ToString() + ";" +
                EnumTranslator.semesterToString[Semester] + ";" +
                OverallRating.ToString() + ";" +
                ContactHours.ToString() + ";" +
                SelfStudyHours.ToString() + ";" +
                Organized.ToString() + ";" +
                Learned.ToString() + ";" +
                Interesting.ToString() + ";" +
                Presentation.ToString() + ";" +
                Comment + ";" +
                date.ToString() + "\n";
            return info;
        }

        public Rating()
        {

        }
    }
}
