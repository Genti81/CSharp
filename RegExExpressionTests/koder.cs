using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"(\w+\,) (\w+) (\(\w+:) (\d+.\d+\)) (\w+:)(\d*-\d*) (\w+:)(\d*)";
        string input = @"Asplund, Mattias (Payment: 35000.00) Telefon:070-6186120 Birthday:1971


";

        foreach (Match m in Regex.Matches(input, pattern))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
    }
}
