using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string input = "")
        {
            if(String.IsNullOrWhiteSpace(input)) return 0;
            var numbersList = input.Split(',');
            return numbersList.Sum(i=> int.Parse(i));
        }
    }
}