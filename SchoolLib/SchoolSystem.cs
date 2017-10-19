using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class SchoolSystem
    {
        List<Class> klasser = new List<Class>();
        public int StudentCount
        {
            get
            {
                return klasser.Count;
            }
               
        }
        public int ClassCount
        {
            get
            {
                return klasser.Sum(c => c.NumberOfStudents);
            }
        }

        public void AddClass(string className, int numberOfStudents)
        {
            var Class = klasser.SingleOrDefault(c => c.Name == className);
            if (Class != null)
            {
                Class.NumberOfStudents += numberOfStudents;
            }
            else
                klasser.Add(new Class { Name = className, NumberOfStudents = numberOfStudents });
        }
    }
}
