using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Data
{
    class DataWriter
    {
        readonly DataUtility du;
        public DataWriter()
        {
            du = new DataUtility();
        }

        /// <summary>
        /// Stores objects of the Type Course, Lecturer, Major, Rating, Student, University.
        /// Will return true if successfull and false if an error occured.
        /// </summary>
        /// <param name="o"></param>
        /// <returns>true when storing was successfull. Otherwise false</returns>
        public bool Store(Object o)
        {
            try
            {
                string path = du.GetPath(o);
                string info = o.ToString();
                File.AppendAllText(path, info);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
