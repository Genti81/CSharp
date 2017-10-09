using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace RegExExpressionTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StringControlCheck()
        {

                string pattern = @"\""?([^\""]*)\""? (\d{2}) (\d*.\d*) (\d*-\d*)";
                string input = @"""Mattias Asplund"" 46 35000.00 070-6186120";

                foreach (Match m in Regex.Matches(input, pattern))
                {
                    Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
                }

        }
    }
}
