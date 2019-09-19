using System;
using System.Collections.Generic;
using System.Text;

namespace GangsOfCsharp
{
    class Test
    {
        static void Main(string[] args)
        {
            University vilnius = new University("Vilnius University", new List<Lecturer>(), new List<Course>());

            Student jan = new Student("TheGermanCodeMachine", "jan.wehner@tprs.stud.vu.lt", "password1", "Jan", "Wehner",
                "Informatics", 6);

            Student evren = new Student("TheTurkishCodeMachine", "evren@gmail.com", "password2", "evren", "can",
                "Mathematics", 7);

            Student didem = new Student("AnotherTurkishCodeMachine", "didem@gmail.com", "password3", "didem", "unknown", 
                "computer sience", 6);

            Lecturer professor = new Lecturer("Max", "Mustermann", vilnius, new List<Course>());

            Course aOOP = new Course("Applied Object Oriented Programming", vilnius, professor, new List<Rating>(), "SS16");

            Rating rating1 = new Rating(vilnius, jan, professor, aOOP, "WS19/20", 10, 4, 6, 3, 5, 5, 3,
                "The course is great and I can only say very positive things about it. Also the guy doing the " +
                "exercise is very handsome.");

            Rating rating2 = new Rating(vilnius, evren, professor, aOOP, "WS19/20", 9, 4, 7, 4, 5, 4, 5,
                "I have never taken a course that great in my whole life. The lecturer is the greatest one I ever head.");
            
            //average overall rating for the course "applied object oriented programming": 9.5
            Console.WriteLine(aOOP.AverageOverallRating);

            //average contact hours for the course "applied object oriented programming": 4
            Console.WriteLine(aOOP.AverageContactHours);

            //average rating of the presentation for the course "applied object oriented programming":4
            Console.WriteLine(aOOP.AveragePresentation);

            //all comments for the course "applied object oriented programming"
            foreach (var comment in aOOP.AllComment)
            {
                Console.WriteLine(comment);
            }

            //average rating of learned for the lecturer "professor": 5
            Console.WriteLine(professor.AverageLearned);

            //average rating of learned for the university "vilnius": 3.5
            Console.WriteLine(vilnius.AverageOrganized);



            /*
            Rating rating3 = new Rating(vilnius, evren, professor, aOOP, "WS19/20", 10, 4, 7, 5, 5, 3, 4,
                "Wow. Just wow. This course was absolutley amazing. Now I feel empty inside because I know I will never experience joy like this again.");

            //average overall rating for the course "applied object oriented programming": 9.5
            Console.WriteLine(aOOP.AverageOverallRating);

            //average contact hours for the course "applied object oriented programming": 4
            Console.WriteLine(aOOP.AverageContactHours);

            //average rating of the presentation for the course "applied object oriented programming":4
            Console.WriteLine(aOOP.AveragePresentation);

            //all comments for the course "applied object oriented programming"
            foreach (var comment in aOOP.AllComment)
            {
                Console.WriteLine(comment);
            }

            //average rating of learned for the lecturer "professor": 5
            Console.WriteLine(professor.AverageLearned);

            //average rating of learned for the university "vilnius": 3.5
            Console.WriteLine(vilnius.AverageOrganized);
            */
        }
    }
}
