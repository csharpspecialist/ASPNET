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
            WriteLine("Please enter a # less than 20");
            string answ = Console.ReadLine();

            int numChoice = Convert.ToInt32(answ);

            int count = 0;

            while (count <= numChoice)
            {
                WriteLine($"we r counting until we get to {numChoice} \n"
                    + $"right now we are at {count}");
                count++;
            }
            WriteLine("The loop has ended");
            Console.ReadLine();



            Parsing();
        }

        private static void Parsing()
        {

            Random rand = new Random();

            int realNum = rand.Next(1,21);

            int numAnsw;



            do
            {
                WriteLine("Please enter a #");
                string answ = Console.ReadLine();

                int count = 0;
                int.TryParse(answ, out numAnsw);

                while (count < numAnsw && numAnsw < 21)
                {
                    WriteLine($"we r counting until we get to {numAnsw} \n"
                        + $"right now we are at {count}");
                    count++;
                   // WriteLine("Please enter a #");
                }



                WriteLine("Its over!!!");
                ReadLine();
            } while (numAnsw != realNum);
            Console.WriteLine("You R A Winna!!!!");
            Console.ReadLine();
         
        }
    }
}
