using System;
using System.Collections.Generic;
using System.Text;

namespace GangsOfCsharp
{
    public class University
    {
        private string name;
        private List<Lecturer> lecturers;
        private List<Course> courses;

        private double averageOverallRating;
        private double averageContactHours;
        private double averageSelfStudyHours;
        private double averageOrganized;
        private double averageLearned;
        private double averageInteresting;
        private double averagePresentation;

        private int amountOverallRating;
        private int amountContactHours;
        private int amountSelfStudyHours;
        private int amountOrganized;
        private int amountLearned;
        private int amountInteresting;
        private int amountPresentation;


        /// <summary>
        /// Constructor for the class University
        /// </summary>
        /// <param name="name">cannot be null</param>
        /// <param name="lecturers">will be set as a empty list for input null</param>
        /// <param name="courses">will be set as a empty list for input null</param>
        public University(string name, List<Lecturer> lecturers, List<Course> courses)
        {
            if (name == null)
                throw new ArgumentNullException("name cannot be null.");
            this.name = name;
            if (lecturers == null)
            {
                this.lecturers = new List<Lecturer>();
            }
            else
            {
                this.lecturers = lecturers;
            }
            if (courses == null)
            {
                this.courses = new List<Course>();
            }
            else
            {
                this.courses = courses;
            }

            this.averageOverallRating = 0;
            this.averageContactHours = 0;
            this.averageSelfStudyHours = 0;
            this.averageOrganized = 0;
            this.averageLearned = 0;
            this.averageInteresting = 0;
            this.averagePresentation = 0;

            this.amountOverallRating = 0;
            this.amountContactHours = 0;
            this.amountSelfStudyHours = 0;
            this.amountOrganized = 0;
            this.amountLearned = 0;
            this.amountInteresting = 0;
            this.amountPresentation = 0;
        }

        public string Name { get => name; }
        public List<Lecturer> Lecturers { get => lecturers; }
        public double AverageOverallRating { get => averageOverallRating; }
        public double AverageContactHours { get => averageContactHours; }
        public double AverageSelfStudyHours { get => averageSelfStudyHours; }
        public double AverageOrganized { get => averageOrganized; }
        public double AverageLearned { get => averageLearned; }
        public double AverageInteresting { get => averageInteresting; }
        public double AveragePresentation { get => averagePresentation; }
        public void addLecturer(Lecturer lecturer)
        {
            if (lecturer == null)
                throw new ArgumentNullException("lecturer cannot be null");
            lecturers.Add(lecturer);
        }
        public List<Course> Courses { get => courses; }
        public void addCourse(Course course)
        {
            if (course == null)
                throw new ArgumentNullException("course cannot be null");
            courses.Add(course);
        }

        /// <summary>
        /// Updates all the average ratings of the university to include the new rating based on the old average 
        /// rating and the amount of ratings
        /// </summary>
        /// <param name="rating">the new rating</param>
        public void addRating(Rating rating)
        {
            if (rating == null)
            {
                throw new ArgumentNullException("rating cannot be null.");
            }
            else
            {
                    this.averageOverallRating = ((this.amountOverallRating * this.averageOverallRating) + rating.OverallRating) / (this.amountOverallRating + 1);
                    this.amountOverallRating++;
                    averageContactHours = ((amountContactHours * averageContactHours) + rating.ContactHours) / (amountContactHours + 1);
                    amountContactHours++;
                    averageSelfStudyHours = ((amountSelfStudyHours * averageSelfStudyHours) + rating.SelfStudyHours) / (amountSelfStudyHours + 1);
                    amountSelfStudyHours++;
                    averageOrganized = ((amountOrganized * averageOrganized) + rating.Organized) / (amountOrganized + 1);
                    amountOrganized++;
                    averageLearned = ((amountLearned * averageLearned) + rating.Learned) / (amountLearned + 1);
                    amountLearned++;
                    averageInteresting = ((amountInteresting * averageInteresting) + rating.Interesting) / (amountInteresting + 1);
                    amountInteresting++;
                    averagePresentation = ((amountPresentation * averagePresentation) + rating.Presentation) / (amountPresentation + 1);
                    amountPresentation++;
                
            }
        }
    }
}
