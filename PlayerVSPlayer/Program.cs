using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerVSPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var ylli = new Player();
            ylli.PlayerName = "Ylli";
            var gentrit = new Player();
            gentrit.PlayerName = "Gentrit";


            while (!ylli.IsDead() && !gentrit.IsDead())
            {
                ylli.AttackPlayer(gentrit);
                gentrit.AttackPlayer(ylli);

                ylli.ShowStatus();
                gentrit.ShowStatus();

            }
            if (ylli.IsDead())
                Console.WriteLine("Ylli died");
            if (gentrit.IsDead())
                Console.WriteLine("Gentrit died");
                Console.ReadLine();
        }
    }
}
