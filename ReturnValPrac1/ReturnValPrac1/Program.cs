using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ReturnValPrac1
{
    class Program
    {
        static void Main(string[] args)
        {

            double totalSum = 0;
            Console.WriteLine("What's your first number to multiply");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("What's your 2nd number to multiply");
            int num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(totalSum);
           totalSum = Multiply(num1,num2);

            Console.WriteLine(totalSum);
            Console.ReadLine();

            int sum = SumVals(1, 5, 2, 9, 8);
            WriteLine($"Summed Values = {sum}");
            ReadKey();

        }

        

        static double Multiply(double myVal1, double myVal2)
        {

            double sum = myVal1 * myVal2;

            return sum;
        }


        static int SumVals(params int[] vals)
        {
            int sum = 0;
            foreach (int singleval in vals)
            {
                sum += singleval;
            }
            return sum;
        }





    }
}
