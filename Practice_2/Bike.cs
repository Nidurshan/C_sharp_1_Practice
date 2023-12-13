using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1_practice.Practice_2
{
    internal class Bike : Car
    {
        public Bike()
        {
        }

        public void IntroToBike()
        {
            Console.WriteLine("These are Bike Details");
        }

        public override void SetInput()
        {
            base.SetInput();
        }

        public override void GetOutput()
        {
            base.GetOutput();
        }
    }
}
