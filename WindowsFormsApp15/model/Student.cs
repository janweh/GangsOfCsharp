using System;
using System.Collections.Generic;
using System.Text;

namespace GangsOfCsharp
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string userName;
        private string email;
        private string password;
        private string areaOfStudies;
        private int semester;
        private List<Rating> givenRatings;

        /// <summary>
        /// Constructor for class Student
        /// </summary>
        /// <param name="userName">cannot be null</param>
        /// <param name="email">cannot be null</param>
        /// <param name="password">cannot be null</param>
        /// <param name="firstName">can be null</param>
        /// <param name="lastName">can be null</param>
        /// <param name="areaOfStudies">can be null</param>
        /// <param name="semester">can be null</param>
        /// <param name="givenRatings">will be set as an empty List for input null</param>
        public Student(string userName, string email, string password, string firstName, 
            string lastName, string areaOfStudies, int semester)
        {
            if (userName == null) {
                throw new ArgumentNullException("UserName cannot be null");
            }
            if (email == null)
            {
                throw new ArgumentNullException("email cannot be null");
            }
            if (password == null)
            {
                throw new ArgumentNullException("password cannot be null");
            }
            
            this.givenRatings = new List<Rating>();
            
            this.userName = userName;
            this.email = email;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.areaOfStudies = areaOfStudies;
            this.semester = semester;
        }

        public string FirstName { get => firstName;}
        public void setFirstName(string firstName)
        {
            if (firstName == null)
                throw new ArgumentNullException("firstName cannot be set to null.");
            this.firstName = firstName;
        }
        public string LastName { get => lastName; }
        public void setLastName(string lastName)
        {
            if (lastName == null)
                throw new ArgumentNullException("lastName cannot be set to null.");
            this.lastName = lastName;
        }
        public string UserName { get => userName; }
        public void setUserName(string userName)
        {
            if (userName == null)
                throw new ArgumentNullException("userName cannot be set to null.");
            this.userName = userName;
        }
        public string Email { get => email; }
        public void setEmail(string email)
        {
            if (email == null)
                throw new ArgumentNullException("email cannot be set to null.");
            this.email = email;
        }
        public string Password { get => password; }
        public void setPassword(string password)
        {
            if (password == null)
                throw new ArgumentNullException("password cannot be set to null.");
            this.password = password;
        }
        public string AreaOfStudies { get => areaOfStudies; }
        public void setAreaOfStudies(string areaOfStudies)
        {
            if (areaOfStudies == null)
                throw new ArgumentNullException("areaOfStudies cannot be set to null.");
            this.areaOfStudies = areaOfStudies;
        }
        public int Semester { get => semester; }
        public void setSemester(int semester)
        {
            this.semester = semester;
        }
        public List<Rating> GivenRatings { get => givenRatings; }
        public void addRating(Rating rating)
        {
            if (rating == null)
                throw new ArgumentNullException("givenRatings cannot be set to null.");
            this.givenRatings.Add(rating);
        }
    }
}
