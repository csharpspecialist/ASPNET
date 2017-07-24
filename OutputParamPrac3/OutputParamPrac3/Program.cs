using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OutputParamPrac3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            //numA and numB must be initialized with a value or this will not work!!!
            int numA = 0, numB = 0;

            Console.WriteLine($"The initial value of num a and num b are {numA} and {numB}");

            p.Mult(out numA, out numB);

            int newNumA = numA;
            int newNumB = numB;

            Console.WriteLine($"the new value of numB is {numA}");

            Console.WriteLine($"the new value of numB is {numB}");

            Waiting.Holder(newNumA, newNumB);

            ReadLine();
        }


        public void Mult(out int fnum, out int sNum)
        {
            int value1, value2;
            Console.WriteLine($" Give me a value for the first number to do math on");
            string val1 = Console.ReadLine();
            int.TryParse(val1, out value1);

            Console.WriteLine($" Give me a value for the first number to do math on");
            string val2 = Console.ReadLine();
            int.TryParse(val2, out value2);

            fnum = value1 + value2;
            sNum = value1 * value2;
            Console.WriteLine($"first, adding {val1} and {val2} = {fnum} ");
            Console.WriteLine($"Second, multiplying {val1} and {val2} = {sNum}");

            fnum = value1 ;

            sNum = value2;

            Console.ReadLine();
        }
    }
}
