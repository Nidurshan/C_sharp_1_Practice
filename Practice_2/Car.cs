using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1_practice.Practice_2
{
    internal class Car : Vehicle
    {
        public string brand, model, color, auto_or_Manual;
        public int speed, tyre, price;

        public Car()
        {
        }

        public void IntroToCar()
        {
            Console.WriteLine("These are Car Details");
        }

        public override void SetInput()
        {
            base.SetInput();

            Console.Write("Enter Brand: ");
            brand = Console.ReadLine();

            Console.Write("Enter Model: ");
            model = Console.ReadLine();

            Console.Write("Enter Automatic or Manual: ");
            auto_or_Manual = Console.ReadLine();

            Console.Write("Enter Color: ");
            color = Console.ReadLine();

            Console.Write("Enter Top Speed: ");
            speed = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Tyre: ");
            tyre = int.Parse(Console.ReadLine());

            Console.Write("Enter Price: ");
            price = int.Parse(Console.ReadLine());
        }

        public override void GetOutput()
        {
            base.GetOutput();

            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Automatic or Manual: " + auto_or_Manual);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Speed: " + speed);
            Console.WriteLine("Tyre: " + tyre);
            Console.WriteLine("Price: " + price);
        }
    }
}