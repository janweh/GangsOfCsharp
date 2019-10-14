using System;
using System.IO;

namespace WindowsFormsApp15.Data
{
    class DataWriter
    {
        private DataUtility du;
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
        public bool store(Object o)
        {
            try
            {
                string path = du.getPath(o);
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
