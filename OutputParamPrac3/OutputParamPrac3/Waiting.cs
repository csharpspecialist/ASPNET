using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParamPrac3
{
    class Waiting
    {

        public static void Holder(int newA, int newB)
        {
            Console.WriteLine("We are now in the holder method \n ");
            Console.WriteLine($"The value of new num a is {newA} and the value of new num B is {newB} in the holder method");

            ReadLine();

        }

    }
}
