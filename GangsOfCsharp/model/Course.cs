using System;
using System.Collections.Generic;
using System.Text;

namespace GangsOfCsharp
{
    class Course
    {
        private string name;
        private University university;
        private Lecturer lecturer;
        private string since;
        private int numberOfRatings;
        private List<Rating> ratings;

        private double averageOverallRating;
        private double averageContactHours;
        private double averageSelfStudyHours;
        private double averageOrganized;
        private double averageLearned;
        private double averageInteresting;
        private double averagePresentation;
        private List<string> allComment;

        private int amountOverallRating;
        private int amountContactHours;
        private int amountSelfStudyHours;
        private int amountOrganized;
        private int amountLearned;
        private int amountInteresting;
        private int amountPresentation;

        /// <summary>
        /// Construtor for the class Course.
        /// Averages and amounts of rating categories will be set to 0.
        /// </summary>
        /// <param name="name">cannot be null</param>
        /// <param name="university">cannot be null</param>
        /// <param name="lecturer">cannot be null</param>
        /// <param name="ratings">will be set as an empty List for input null</param>
        /// <param name="since">cannot be null</param>
        public Course(string name, University university, Lecturer lecturer, List<Rating> ratings, string since)
        {
            if (name == null)
                throw new ArgumentNullException("name cannot be null.");
            if (university == null)
                throw new ArgumentNullException("university cannot be null.");
            if (lecturer == null)
                throw new ArgumentNullException("lecturer cannot be null.");
            if (since == null)
                throw new ArgumentNullException("since cannot be null.");
            this.name = name;
            this.university = university;
            this.lecturer = lecturer;
            this.since = since;
            if(ratings == null)
            {
                this.ratings = new List<Rating>();
            }
            else
            {
                this.ratings = ratings;
            }

            this.averageOverallRating = 0;
            this.averageContactHours = 0;
            this.averageSelfStudyHours = 0;
            this.averageOrganized = 0;
            this.averageLearned = 0;
            this.averageInteresting = 0;
            this.averagePresentation = 0;
            this.allComment = new List<string>();

            this.amountOverallRating = 0;
            this.amountContactHours = 0;
            this.amountSelfStudyHours = 0;
            this.amountOrganized = 0;
            this.amountLearned = 0;
            this.amountInteresting = 0;
            this.amountPresentation = 0;
    }

        public string Name { get => name; }
        public string Since { get => since; }
        public University University { get => university; }
        public Lecturer Lecturer { get => lecturer; }
        public List<Rating> Ratings { get => ratings; }
        public double AverageOverallRating { get => averageOverallRating; }
        public double AverageContactHours { get => averageContactHours; }
        public double AverageSelfStudyHours { get => averageSelfStudyHours; }
        public double AverageOrganized { get => averageOrganized; }
        public double AverageLearned { get => averageLearned; }
        public double AverageInteresting { get => averageInteresting; }
        public double AveragePresentation { get => averagePresentation; }
        public List<string> AllComment { get => allComment; }
        /// <summary>
        /// adds the new rating and updates averages
        /// </summary>
        /// <param name="rating">the rating to be added</param>
        public void addRating(Rating rating)
        {
            if (rating == null)
            {
                throw new ArgumentNullException("rating cannot be null.");
            }
            else
            {
                //TODO only one of these 2 methods to store ratings is really needed. Still have to choose which is better
                //not sure whether its smarter to calculate the averages out of all ratings every time the average is requested
                //or have the averages stored and always update them when changes occur
                //the same discussion concerns Lecturer and University
                //1
                ratings.Add(rating);
                numberOfRatings++;
                //2
                updateRatings(rating);
            }
        }

        
        /// <summary>
        /// Updates all the average ratings of the course to include the new rating based on the old average 
        /// rating and the amount of ratings
        /// </summary>
        /// <param name="rating">the new rating</param>
        private void updateRatings(Rating rating)
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
            if (rating.Organized!= null)
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
            if (rating.Comment != null)
            {
                allComment.Add(rating.Comment);
            }
        }

        



    }
}
