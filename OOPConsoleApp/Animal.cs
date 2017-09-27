using System;

namespace OOPConsoleApp
{
    internal class Animal
    {
        string txt = "Animals inheritance:";
        internal virtual void Eat()
        {
            Console.WriteLine($"{txt} MMM grumph, yummy!");
        }

        internal void MoveLeft()
        {
            Console.WriteLine($"{txt} Animal moves left!"); 
        }

        internal void MoveRight()
        {
            Console.WriteLine($"{txt} Animal moves right!");
        }
    }
}