using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilderApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var aCar = new Car("Mustang Origin");
            var anEngine = new Engine(850, 250000M);
            var door1 = new Door(15000M);
            var door2 = new Door(16000M);
            var chassi = new Chassi(650000M);
            aCar.Parts.Add(anEngine);
            aCar.Parts.Add(door1);
            aCar.Parts.Add(door2);
            aCar.Parts.Add(chassi);
            //aCar.Parts.Add(Tyre1);
            //aCar.Parts.Add(Tyre2);
            //aCar.Parts.Add(Tyre3);
            //aCar.Parts.Add(Tyre4);
            decimal cost = aCar.Cost;
            Console.WriteLine($"{aCar} costs {cost}");
        }
    }
}
