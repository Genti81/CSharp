using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameDiceLib;
using System.Diagnostics;

namespace DiceGameTestsLib
{
    [TestClass]
    public class DiceGame
    {
        [TestMethod]
        public void Dices()
        {
            Random random = new Random();
            var sut = new Game(random);
            while (!sut.YouAreAWinner)
            {
                sut.ThrowDices();
                Debug.WriteLine(ToString());
            }
                Debug.WriteLine($"Won after {sut.ThrowsMade} throws.");
                Assert.AreEqual(7, sut.NumberofPoints);
        }
    }
}
