using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite color?");
            string favorite = Console.ReadLine();
            
switch(favorite)
{
    case "Red":
        Console.WriteLine("Red is one that is chosen often");
        break;

case "Blue":
    Console.WriteLine("Blue is one that is chosen often");
    break;

case "Green":
    Console.WriteLine("Green is one that is chosen often");
    break;

case "Yellow":
    Console.WriteLine("Yellow is one that is chosen often");
    break;

case "Orange":
    Console.WriteLine("Orange is one that is chosen often");
    break;

case "White":
    Console.WriteLine("White is the absence of all colors");
    break;

case "Black":
    Console.WriteLine("Black is the presence of all colors");
    break;


default:
    Console.WriteLine("We don't understand that color choice");
    break;
}
  Console.ReadLine();           

        }
    }
}
