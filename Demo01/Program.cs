using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalAge = 0;
            for (int age = 0; age < 100; age++)
            {
                totalAge += age;
                Console.WriteLine(age);
            }
            Console.WriteLine(totalAge);
        }
    }
}
