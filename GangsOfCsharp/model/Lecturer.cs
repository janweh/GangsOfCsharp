using System;
using System.Collections.Generic;
using System.Text;

namespace GangsOfCsharp
{
    class Lecturer
    {
        private string firstName;
        private string lastName;
        private University university;
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
        /// Constructor for the class Lecturer
        /// </summary>
        /// <param name="firstName">cannot be null</param>
        /// <param name="lastName">cannot be null</param>
        /// <param name="university">cannot be null</param>
        /// <param name="courses">will be set as an empty List for input null</param>
        public Lecturer(string firstName, string lastName, University university, List<Course> courses)
        {
            if(firstName == null) { throw new ArgumentNullException("firstName cannot be null."); }
            if (lastName == null) { throw new ArgumentNullException("lastName cannot be null."); }
            if (university == null) { throw new ArgumentNullException("university cannot be null."); }
       
            this.firstName = firstName;
            this.lastName = lastName;
            this.university = university;
            if (courses == null)
            {
                this.courses = new List<Course>();
            }
            else {
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

        public string FirstName { get => firstName; }
        public void setFirstName(string firstName)
        {
            this.firstName = firstName ?? throw new ArgumentNullException("firstName cannot be null.");
        }
        public string LastName { get => lastName; }
        public void setLastName(string lastName)
        {
            if (lastName == null)
                throw new ArgumentNullException("lastName cannot be null.");
            this.lastName = lastName;
        }
        public University University { get => university; }
        public List<Course> Courses { get => courses; }
        public double AverageOverallRating { get => averageOverallRating; }
        public double AverageContactHours { get => averageContactHours; }
        public double AverageSelfStudyHours { get => averageSelfStudyHours; }
        public double AverageOrganized { get => averageOrganized; }
        public double AverageLearned { get => averageLearned; }
        public double AverageInteresting { get => averageInteresting; }
        public double AveragePresentation { get => averagePresentation; }
        public void addCourse(Course course)
        {
            if (course == null)
                throw new ArgumentNullException("course cannot be null.");
            courses.Add(course);
        }
        public void setUniversity(University university)
        {
            if (university == null)
                throw new ArgumentNullException("university cannot be null.");
            this.university = university;
        }

        /// <summary>
        /// Updates all the average ratings of the lecturer to include the new rating based on the old average 
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
                if (rating.OverallRating != null)
                {
                    this.averageOverallRating = ((this.amountOverallRating * this.averageOverallRating) + rating.OverallRating) / (this.amountOverallRating + 1);
                    this.amountOverallRating++;
                }
                if (rating.ContactHours != null)
                {
                    averageContactHours = ((amountContactHours * averageContactHours) + rating.ContactHours) / (amountContactHours + 1);
                    amountContactHours++;
                }
                if (rating.SelfStudyHours != null)
                {
                    averageSelfStudyHours = ((amountSelfStudyHours * averageSelfStudyHours) + rating.SelfStudyHours) / (amountSelfStudyHours + 1);
                    amountSelfStudyHours++;
                }
                if (rating.Organized != null)
                {
                    averageOrganized = ((amountOrganized * averageOrganized) + rating.Organized) / (amountOrganized + 1);
                    amountOrganized++;
                }
                if (rating.Learned != null)
                {
                    averageLearned = ((amountLearned * averageLearned) + rating.Learned) / (amountLearned + 1);
                    amountLearned++;
                }
                if (rating.Interesting != null)
                {
                    averageInteresting = ((amountInteresting * averageInteresting) + rating.Interesting) / (amountInteresting + 1);
                    amountInteresting++;
                }
                if (rating.Presentation != null)
                {
                    averagePresentation = ((amountPresentation * averagePresentation) + rating.Presentation) / (amountPresentation + 1);
                    amountPresentation++;
                }
            }
        }

    }
}
