using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace WhileLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Please enter a #");
            int numAnsw = int.Parse(ReadLine());

            int count = 0;


            while (count < numAnsw)
            {
                WriteLine($"we r counting until we get to {numAnsw} \n" 
                    + $"right now we are at {count}");
                count++;
            }



            WriteLine("Its over!!!");
            ReadLine();
        }
    }
}
