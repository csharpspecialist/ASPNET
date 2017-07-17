using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4];

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;

            int[] newArray = { 577, 723, 633, 201, 444, 139, 852 };

            string[] crazies = { "Now", "Bliss", "strike", "crystal", };
            char[] singles = {'s', 'm', 'i', 'l', 'e',' ', 'f', 'o', 'r', ' ', 'm', 'e', };

            //for (int x = 0; x < 4; x=x+1)
            //{
            //    Console.WriteLine(numbers[x]);

            //}

            Console.ReadLine();

            //for (int i = 0; i < newArray.Length; i++)
            //{
            //    Console.WriteLine(newArray[i]);
            //}
            //Console.ReadLine();

            //for (int i = 0; i < crazies.Length; i++)
            //{
            //    Console.WriteLine(crazies[i]);
            //}
            //Console.ReadLine();


            //outputs the words smile for me to console
            //for (int i = 0; i < singles.Length; i++)
            //{
            //    Console.Write(singles[i]);
            //}
            //Console.ReadLine();

            //sorts an array + puts in numeric order
            Array.Sort(newArray);
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }

            Console.ReadLine();



            
        }
    }
}
