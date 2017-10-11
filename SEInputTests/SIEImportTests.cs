using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace SEInputTests
{
    [TestClass]
    public class SIEImportTests
    {
        [TestMethod]
        public void TestTransaction()
        {
            var accounts = new Dictionary<string, decimal>(); 
            var streamReader = File.OpenText(@"MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt");
            while(true)
                {
                var line = streamReader.ReadLine();
                if (line == null)
                    break;
                string pattern = @"#TRANS (\d{4}) {.*} (-?\d*.\d*)";
                var match = Regex.Match(line, pattern);
                if (match.Success)
                {
                    var accountID = match.Groups[1].Value;
                    var amount = decimal.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
                    Debug.WriteLine($"{accountID} {amount}");
                    if (accounts.ContainsKey(accountID))
                        accounts[accountID] += amount;
                    else
                        accounts[accountID] = amount;
                }
            }

            foreach (var entry in accounts.OrderBy(e => e.Key))
                Console.WriteLine($"{entry.Key} {entry.Value.ToString("F2")}");

            Debug.WriteLine(accounts.Sum(entry => entry.Value));
        }

        [TestMethod]
        public void TwoPhase()
        {
            var accounts = new Dictionary<string, decimal>();
            var streamReader = File.OpenText(@"MATTIAS0_SIE4 2015-09-01 - 2016-08-31.SE.txt");
            while (true)
            {
                var line = streamReader.ReadLine();
                if (line == null)
                    break;
                string pattern = @"#TRANS (\d{4}) {.*} (-?\d*.\d*)";
                var match = Regex.Match(line, pattern);
                if (match.Success)
                {
                    var accountID = match.Groups[1].Value;
                    var amount = decimal.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
                    Debug.WriteLine($"{accountID} {amount}");
                    if (accounts.ContainsKey(accountID))
                        accounts[accountID] += amount;
                    else
                        accounts[accountID] = amount;
                }
            }

            foreach (var entry in accounts.OrderBy(e => e.Key))
                Console.WriteLine($"{entry.Key} {entry.Value.ToString("F2")}");

            Debug.WriteLine(accounts.Sum(entry => entry.Value));
        }
    }
}
