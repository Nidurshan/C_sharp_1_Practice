using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1_practice.Practice_3
{
    internal class Rectrangle:Shape
    {
        public int RectrangleArea;

        public Rectrangle() 
        {
        }

        public override int Length { get => base.Length; set => base.Length = value; }
        public override int Width { get => base.Width; set => base.Width = value; }

        public override void Find_Area()
        {
            base.Find_Area();

            RectrangleArea = Length * Width;
            Console.WriteLine("Rectrangle Area: " + RectrangleArea);
        }
    }
}
