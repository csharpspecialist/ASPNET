using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MultiplyUserInput
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Enter the first number to multiply");
            string tempNumber1 = ReadLine();

            int firstNumber = Convert.ToInt32(tempNumber1);

            WriteLine("Enter the second number to multiply");
            string tempNumber2 = ReadLine();
            
            int secondNumber = Convert.ToInt32(tempNumber2);
            
int total = firstNumber * secondNumber;

WriteLine($"The first number {firstNumber} multiplied by {secondNumber} equals {total}");

ReadLine();




        }
    }
}
