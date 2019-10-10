using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.model;

namespace WindowsFormsApp15.Data
{
    class AddTestData
    {
        public AddTestData()
        {
            DataWriter dw = new DataWriter();
            University u = new University("Vilnius University");
            dw.store(u);
            Major m = new Major("Computer Sience", u);
            dw.store(m);
            Lecturer l = new Lecturer("Donatas Kimutis", u, m);
            dw.store(l);
            Course c = new Course("Applied Object Oriented Programming", u, l, "WS18/19", m);
            dw.store(c);
            Student s = new Student("TheGermanCodeMachine", "password1", u, m,
                "business informatics", 6);
            dw.store(s);
            Rating r = new Rating(s, c, "WS19/20", 5, 4, 8, 4, 5, 5, 4, "Nice");
            dw.store(r);
        }
    }
}
