using System;
using System.IO;
using WindowsFormsApp15.model;

namespace WindowsFormsApp15.Data
{
    class TestData
    {
        public TestData()
        {

        }

        public void AddData()
        {
            DataWriter dw = new DataWriter();
            University u = new University("Vilnius University");
            dw.Store(u);
            Major m = new Major("Computer Sience", u);
            dw.Store(m);
            Lecturer l = new Lecturer("Donatas Kimutis", u, m);
            dw.Store(l);
            Course c = new Course("Applied Object Oriented Programming", u, l, Semester.WS1819, m);
            dw.Store(c);
            Student s = new Student("TheGermanCodeMachine", "password1", u, m,
                "business informatics", 6);
            dw.Store(s);
            Rating r = new Rating(s, c, Semester.WS1920, 5, 4, 8, 4, 5, 5, 4, "Nice", DateTime.Now);
            dw.Store(r);
            Student s1 = new Student("a", "b", u, m, "c", 6);
            dw.Store(s1);
            Student s2 = new Student("a", "b", u, m, "c", 6);
            dw.Store(s2);
            Student s3 = new Student("a", "b", u, m, "c", 6);
            dw.Store(s3);
            Student s4 = new Student("a", "b", u, m, "c", 6);
            dw.Store(s4);
            Rating r1 = new Rating(s1, c, Semester.WS1920, 5, 4, 8, 4, 5, 5, 4, "Nice lalallalallallallalallallallallallalallalallallalallallalallalallallalallallalallalallalalalla", DateTime.Now);
            dw.Store(r1);
            Rating r2 = new Rating(s2, c, Semester.WS1920, 5, 4, 8, 4, 5, 5, 4, "Nice", DateTime.Now);
            dw.Store(r2);
            Rating r3 = new Rating(s3, c, Semester.WS1920, 5, 4, 8, 4, 5, 5, 4, "Nice", DateTime.Now);
            dw.Store(r3);
            Rating r4 = new Rating(s4, c, Semester.WS1920, 5, 4, 8, 4, 5, 5, 4, "Nice", DateTime.Now);
            dw.Store(r4);
        }

        public void DeleteAllTestData()
        {
            DataUtility du = new DataUtility();
            File.WriteAllText(du.GetPath(typeof(University)), String.Empty);
            File.WriteAllText(du.GetPath(typeof(Course)), String.Empty);
            File.WriteAllText(du.GetPath(typeof(Lecturer)), String.Empty);
            File.WriteAllText(du.GetPath(typeof(Major)), String.Empty);
            File.WriteAllText(du.GetPath(typeof(Rating)), String.Empty);
            File.WriteAllText(du.GetPath(typeof(Student)), String.Empty);
        }
    }
}
