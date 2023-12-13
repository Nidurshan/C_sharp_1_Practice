using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1_practice.Practice_3
{
    internal class Squre:Shape
    {
        public int SqureArea;

        public Squre() 
        {
        }

        public override int Length { get => base.Length; set => base.Length = value; }

        public override void Find_Area()
        {
            base.Find_Area();

            SqureArea = Length * Length;
            Console.WriteLine("Squre Area: " + SqureArea);
        }
    }
}
