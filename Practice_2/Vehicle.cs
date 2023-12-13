using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1_practice.Practice_2
{
    internal class Vehicle
    {
        public string favouriteVehicles;

        public Vehicle() 
        {
        }

        public virtual void SetInput()
        {
            Console.Write("Enter Your Favourite Vehicles: ");
            favouriteVehicles = Console.ReadLine();
        }

        public virtual void GetOutput()
        {
            Console.WriteLine("Favourite Vehicle: " + favouriteVehicles);
        }
    }
}