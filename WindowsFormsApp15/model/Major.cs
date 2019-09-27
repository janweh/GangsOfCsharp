using GangsOfCsharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangsOfCsharp
{
    public class Major
    {
        private University university;
        private int majorID;
        private string majorName;

        public Major(int majorID, string name, University university)
        {
            if (university == null)
                throw new ArgumentNullException("university cannot be null!");
            if (name == null)
                throw new ArgumentNullException("name cannot be null!");
            this.majorName = name;
            this.majorID = majorID;
            this.university = university;
        }
        public int MajorID { get => majorID; }
        public string Name { get => majorName; }
        public University University { get => university; }
    }
}
