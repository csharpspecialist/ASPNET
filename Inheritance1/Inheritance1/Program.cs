using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {

            FullTimeEmployee manager = new FullTimeEmployee();
            PartTimeEmployee pt = new PartTimeEmployee();
            Employee emp = new Employee();

            manager.FirstName = "Mike";
            manager.LastName = "Shubick";
            manager.Email = "BigMShub@gmail.com";
            manager.Address = "2100 Dude Ave";


     


            emp.PrintFullName();
            Console.ReadKey();
        }
    }
}
