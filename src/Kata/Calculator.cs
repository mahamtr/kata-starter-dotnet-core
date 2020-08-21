using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string input = "")
        {
            if(String.IsNullOrWhiteSpace(input)) return 0;
            var separators = new[] {',', '\n'};
            var numbersList = input.Split(separators, StringSplitOptions.None);
            return numbersList.Sum(i=> int.Parse(i));
        }
    }
}