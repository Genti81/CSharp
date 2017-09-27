using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiceLib
{
    public class Game
    {
        private Dice firstDice;
        private Dice secondDice;
        private int _throwsMade = 0;

        private Random random;

        public Game(Random random)
        {
            this.random = random;
            firstDice = new Dice(random);
            secondDice = new Dice(random);
        }

        public bool YouAreAWinner {
            get
            {
                return NumberofPoints == 7;
            }
        }
        public int NumberofPoints {
            get
            {
                return firstDice.NumberOfPoints + secondDice.NumberOfPoints;
            }
                
        }
        public object ThrowsMade {
            get
            {
                return _throwsMade++;
            }
                
        }

        public void ThrowDices()
        {
            firstDice.Throw();
            secondDice.Throw();
            _throwsMade++;
        }

        public override string ToString()
        {
            return $"Dice one: {firstDice.NumberOfPoints}, Dice two: {secondDice.NumberOfPoints}";
        }
    }
}
