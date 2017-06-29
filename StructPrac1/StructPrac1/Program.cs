using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StructPrac1
{
    class MyClass
    {
        public int val;
    }
    struct myStruct
    {
        public int val;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass objectA = new MyClass();
            MyClass objectB = objectA;
            objectA.val = 10;
            objectB.val = 20;
            myStruct structA = new myStruct();
            myStruct structB = structA;
            structA.val = 30;
            structB.val = 40;
            WriteLine($"objectA.val = {objectA.val}");
            WriteLine($"objectB.val = {objectB.val}");
            WriteLine($"structA.val = {structA.val}");
            WriteLine($"structB.val = {structB.val}");
            ReadKey();

            KeyDemo();

        }

        public static void KeyDemo()
        {
            Dictionary<string, int> things = new Dictionary<string, int>();
            things.Add("Green Things", 29);
            things.Add("Blue Things", 94);
            things.Add("Yellow Things", 34);
            things.Add("Red Things", 52);
            things.Add("Brown Things", 27);
          
            foreach (string key in things.Keys)
            {
                WriteLine(key);
            }
            foreach (
          int value in things.Values)
            {
                WriteLine(value);
            }

            ReadKey();

            foreach (KeyValuePair<string, int> thing in things)
            {
                WriteLine($"{thing.Key} = {thing.Value}");
            }

            ReadKey();

        }



    }
}
