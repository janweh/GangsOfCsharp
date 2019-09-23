using GangsOfCsharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.model
{
    public class Major
    {
        public University university;
        private int majorID;
        private string name;

        public Major(University uni, string name)
        {


            this.university = uni;
            this.name = name;
            DataSearch ds = new DataSearch();
            this.majorID = ds.AddMajor(this);
        }
        public int MajorID { get => majorID; }
        public string Name { get => name; }
    }
}
