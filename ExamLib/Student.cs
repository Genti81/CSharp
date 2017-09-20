using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib
{
    public class Student
    {
        private string Name;

        public Student(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
