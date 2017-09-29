using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentApp
{
    internal class School
    {
        private string name;

        public List<Class> Klasser { get; internal set; }
            = new List<Class>();

        public School(string name)
        {
            this.name = name;
        }

        public int NumberOfStudents
        {
            get
            {
                return this.Klasser.Sum(klass => klass.antElever);
            }
                
        }

        public override string ToString()
        {
            return name + " har " + NumberOfStudents.ToString();
        }

    }
}