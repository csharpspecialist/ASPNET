using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Accesors_Methods1
{
    class Automobile
    {
        //declaring accessors
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Miles { get; set; }
        public string InventoryNumber { get; set; }


        public void PrintCar()
        {

            WriteLine($"listed car is a {Make} , {Model}" +
                 $" { Year} , { Color}, {Miles}");

        }

        public void SpecialCar()
        {


            WriteLine($"{InventoryNumber} - {Year} {Make} , {Model} This Week!!!");


        }



    }
}
