using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string input = "")
        {
            if(String.IsNullOrWhiteSpace(input)) return 0;
            var separators = new[] {',', '\n',';'};
            string stringToSplit = input;
            if (input.Contains("//"))
            {
                var numbersAfterBreakLine = input.Split("\n");
                stringToSplit = numbersAfterBreakLine[1];
            }
            
            var numbersList = stringToSplit.Split(separators, StringSplitOptions.None);
            return numbersList.Sum(i=> int.Parse(i));
        }
    }
}