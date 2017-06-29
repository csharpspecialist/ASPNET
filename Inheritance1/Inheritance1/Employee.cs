using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Employee
    {
        public string Address { get; set; }
        public string FirstName;
        public string LastName;
        public string Email;

        //this is incomplete... I would need an array in the program class to cycle thru the names 
        public void PrintFullName()
        {

            Console.WriteLine($"Your manager is {FirstName} {LastName}");

        }


    }
}
