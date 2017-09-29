using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Program
    {
        public static Class HTML { get; private set; }

        static void Main(string[] args)
        {
            var aSchool = new School("EC Utbildning");
            var Mvc = new Class("MVC", 10);
            var Charp = new Class("Csharp", 15);
            var Cplus = new Class("C#", 50);
            var Java = new Class("Java", 30);
            var Typescript = new Class("Typescript", 40);
            var CSS = new Class("CSS", 20);

            aSchool.Klasser.Add(Mvc);
            aSchool.Klasser.Add(Charp);
            aSchool.Klasser.Add(Cplus);
            aSchool.Klasser.Add(Java);
            aSchool.Klasser.Add(Typescript);
            aSchool.Klasser.Add(CSS);

            int sum = aSchool.NumberOfStudents;
            Console.WriteLine($"{aSchool} studenter");

        }
    }
}
