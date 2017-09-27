using System;

namespace OOPConsoleApp
{
    class Lion : Animal
    {
        public Lion()
            {
                
            }
        internal override void Eat()
        {
            base.Eat();
            Console.WriteLine("Lions expression event: Indeed Eating!");
        }
    }
}
