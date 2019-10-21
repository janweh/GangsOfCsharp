using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            dw.store(u);
            Major m = new Major("Computer Sience", u);
            dw.store(m);
            Lecturer l = new Lecturer("Donatas Kimutis", u, m);
            dw.store(l);
            Course c = new Course("Applied Object Oriented Programming", u, l, Semester.WS1819, m);
            dw.store(c);
            Student s = new Student("TheGermanCodeMachine", "password1", u, m,
                "business informatics", 6);
            dw.store(s);
            Rating r = new Rating(s, c, Semester.WS1920, 5, 4, 8, 4, 5, 5, 4, "Nice", DateTime.Now);
            dw.store(r);
            Student s1 = new Student("a", "b", u, m, "c", 6);
            dw.store(s1);
            Student s2 = new Student("a", "b", u, m, "c", 6);
            dw.store(s2);
            Student s3 = new Student("a", "b", u, m, "c", 6);
            dw.store(s3);
            Student s4 = new Student("a", "b", u, m, "c", 6);
            dw.store(s4);
            Rating r1 = new Rating(s1, c, Semester.WS1920, 5, 4, 8, 4, 5, 5, 4, "Nice lalallalallallallalallallallallallalallalallallalallallalallalallallalallallalallalallalalalla", DateTime.Now);
            dw.store(r1);
            Rating r2 = new Rating(s2, c, Semester.WS1920, 5, 4, 8, 4, 5, 5, 4, "Nice", DateTime.Now);
            dw.store(r2);
            Rating r3 = new Rating(s3, c, Semester.WS1920, 5, 4, 8, 4, 5, 5, 4, "Nice", DateTime.Now);
            dw.store(r3);
            Rating r4 = new Rating(s4, c, Semester.WS1920, 5, 4, 8, 4, 5, 5, 4, "Nice", DateTime.Now);
            dw.store(r4);
        }

        public void DeleteAllTestData()
        {
            DataUtility du = new DataUtility();
            File.WriteAllText(du.getPath(typeof(University)), String.Empty);
            File.WriteAllText(du.getPath(typeof(Course)), String.Empty);
            File.WriteAllText(du.getPath(typeof(Lecturer)), String.Empty);
            File.WriteAllText(du.getPath(typeof(Major)), String.Empty);
            File.WriteAllText(du.getPath(typeof(Rating)), String.Empty);
            File.WriteAllText(du.getPath(typeof(Student)), String.Empty);
        }
    }
}
