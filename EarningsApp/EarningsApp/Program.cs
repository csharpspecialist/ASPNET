using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EarningsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double weeklySum = 0;
            double monthlySum = 0;
            double yearlySum = 0;

            WriteLine("Enter you name");
            string name = ReadLine();

            Console.WriteLine("What's do you make an hour");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("How many hours do you work a week");
            int num2 = Convert.ToInt16(Console.ReadLine());


            weeklySum = num1 * num2;

            monthlySum = weeklySum * 4;

            yearlySum = weeklySum * 52;


            WriteLine($" \n \n {name} your weekly income is ${weeklySum} \n");

            WriteLine($" {name} your monthly income is ${monthlySum} \n ");

            WriteLine($" {name} your yearly income is ${yearlySum}  \n ");

            ReadKey();









        }
    }
}
