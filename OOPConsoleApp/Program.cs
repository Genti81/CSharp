using System;

namespace OOPConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //StudentDemo();
            InheritanceDemo();
            Console.ReadLine();
        }

        private static void InheritanceDemo()
        {
            Animal animal = new Animal();
            animal.Eat();
            animal.MoveLeft();
            animal.MoveRight();
            Lion lion = new Lion();
            lion.Eat();
        }

        private static void StudentDemo()
        {
            var gentrit = new Student();
            gentrit.Name = "Gentrit Sahiti";
            gentrit.Email = "sahiti.gentrit@gmail.com";
            gentrit.Phone = "0723707515";
            gentrit.TooTired += Gentrit_Sahiti;
            gentrit.StudyHarder();
            gentrit.StudyHarder();
            gentrit.StudyHarder();
            Console.WriteLine($" Hello {gentrit}");
            Console.ReadLine();
        }

        private static void Gentrit_Sahiti(object sender, EventArgs e)
        {
            //Event som anropas bara när avsändaren åtgärder.
            //Detta är en callback metod som kallas när ett event inträffar.
            Console.WriteLine("Student needs to rest!");
        }
    }
}
