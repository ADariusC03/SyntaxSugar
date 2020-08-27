using System;

namespace SyntaxSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inferred typing and Ternary operator

            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";
            Console.WriteLine(response);



            // String Interpolation

            
            var sum = 4;
            string tell = (sum < 9) ? $"{sum} is greater than nine" : $" {sum} is less than nine";
            Console.WriteLine(tell);


        }
    }
}
