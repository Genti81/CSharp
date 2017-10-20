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

            ylli.SetAttackPower(20);
            ylli.AttackPlayer(gentrit);

        }
    }
}
