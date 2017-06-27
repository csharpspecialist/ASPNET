using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Accesors_Methods1
{
    class Program
    {
        static void Main(string[] args)
        {

            Automobile [] inventory = new Automobile[3];

            Automobile car1 = new Automobile();

            car1.Make = "Chevy";
            car1.Model = "Impala";
            car1.Color = "Black";
            car1.Year = 2012;
            car1.Miles = 54393;
            car1.InventoryNumber = "366Z";


            Automobile car2 = new Automobile();

            car2.Make = "Dodge";
            car2.Model = "Journey";
            car2.Color = "Green";
            car2.Year = 2014;
            car2.Miles = 6293;
            car2.InventoryNumber = "2705A";

            Automobile car3 = new Automobile();

            car3.Make = "Dodge";
            car3.Model = "Journey";
            car3.Color = "Green";
            car3.Year = 2014;
            car3.Miles = 6293;
            car3.InventoryNumber = "7329F";

            try  // change the # of array elements in line 14 for this to trigger!!!
            {

                inventory[0] = car1;
            inventory[1] = car2;
            inventory[2] = car3;


            Console.WriteLine("Our inventory includes the following vehicles");
         
            for (int i = 0; i < inventory.Length; i++)
            {
                inventory[i].PrintCar();
            }

            Console.WriteLine("");
            Console.WriteLine($"We have a special on the ");
            inventory[1].SpecialCar();
            Console.WriteLine("There are " + inventory.Count() + " vehicles in our inventory at this time");


            Console.ReadLine();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
