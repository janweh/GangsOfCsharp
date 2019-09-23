using System;
using System.Collections.Generic;
using System.Text;

namespace GangsOfCsharp
{
    public class Rating
    {
        private University university;
        private Student student;
        private Lecturer lecturer;
        private Course course;

        //TODO: maybe make an enum out of this
        /// <summary>
        /// should consist of "SS" or "WS" and the year the course was taken in
        /// E.g. "SS19" or "WS17/18"
        /// </summary>
        private string semester;
        /// <summary>
        /// score from 1-10
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

        /// <summary>
        /// Constructor for the class Rating
        /// </summary>
        /// <param name="university">cannot be null</param>
        /// <param name="student">cannot be null</param>
        /// <param name="lecturer">cannot be null</param>
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
        public Rating(University university, Student student, Lecturer lecturer, Course course, 
            string semester, int overallRating, int contactHours, int selfStudyHours, int organized, 
            int learned, int interesting, int presentation, string comment)
        {
            if (university == null) { throw new ArgumentNullException("university cannot be null"); }
            if (student == null) { throw new ArgumentNullException("student cannot be null"); }
            if (lecturer == null) { throw new ArgumentNullException("lecturer cannot be null"); }
            if (course == null) { throw new ArgumentNullException("course cannot be null"); }
            if (semester == null) { throw new ArgumentNullException("semester cannot be null"); }

            if (overallRating < 1 || overallRating > 10) { throw new ArgumentException("overallRating has to be between 1-10."); }
            if (contactHours < 0) { throw new ArgumentException("contactHours has to be positive"); }
            if (selfStudyHours < 0) { throw new ArgumentException("selfStudyHours has to be positive"); }
            if (organized < 1 || organized > 5) { throw new ArgumentException("organized has to be between 1-5"); }
            if (learned < 1 || learned > 5) { throw new ArgumentException("learned has to be between 1-5"); }
            if (interesting < 1 || interesting > 5) { throw new ArgumentException("interesting has to be between 1-5"); }
            if (presentation < 1 || presentation > 5) { throw new ArgumentException("presentation has to be between 1-5"); }
            if (lecturer != course.Lecturer) { throw new ArgumentException("the lecturer has to match the lecturer of the rated course."); }
            //TODO: check whether semester is smaller or equal the attribute since (semester)

            this.university = university;
            this.student = student;
            this.lecturer = lecturer;
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

            this.course.addRating(this);
            this.lecturer.addRating(this);
            this.university.addRating(this);
            this.student.addRating(this);
        }

        public string Semester { get => semester; set => semester = value; }
        public int OverallRating { get => overallRating; set => overallRating = value; }
        public int ContactHours { get => contactHours; set => contactHours = value; }
        public int SelfStudyHours { get => selfStudyHours; set => selfStudyHours = value; }
        public int Organized { get => organized; set => organized = value; }
        public int Learned { get => learned; set => learned = value; }
        public int Interesting { get => interesting; set => interesting = value; }
        public int Presentation { get => presentation; set => presentation = value; }
        public string Comment { get => comment; set => comment = value; }
        public University University { get => university; }
        public void setUniversity(University university) {
            if (university == null)
                throw new ArgumentNullException("university cannot be null.");
            this.university = university;
        }
        public Student Student { get => student; }
        public void setStudent(Student student)
        {
            if (student == null)
                throw new ArgumentNullException("student cannot be null.");
            this.student = student;
        }
        public Lecturer Lecturer { get => lecturer; }
        public void setLecturer(Lecturer lecturer)
        {
            if (lecturer == null)
                throw new ArgumentNullException("lecturer cannot be null.");
            this.lecturer = lecturer;
        }
        public Course Course { get => course; }
        public void setCourse(Course course)
        {
            if (course == null)
                throw new ArgumentNullException("course cannot be null.");
            this.course = course;
        }
    }
}
