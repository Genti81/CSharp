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
            var gentrit = new Player();

            ylli.SetAttackPower(80);
            ylli.AttackPlayer(gentrit);

            Console.WriteLine("Step 5: \n Gentrit has currently: \n" + gentrit.GetHealth() + " HP");
            Console.ReadLine();
        }
    }
}
