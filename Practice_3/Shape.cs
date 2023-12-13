using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1_practice.Practice_3
{
    internal class Shape
    {
        public int x, y;

        public Shape() 
        {
        }

        public Shape(int lenght, int width)
        {
            this.x = lenght;
            this.y = width;
        }

        public void SetValues()
        {
            Console.Write("Enter Length: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Enter Width: ");
            y = int.Parse(Console.ReadLine());
        }

        public virtual void Find_Area() 
        {
            throw new NotImplementedException();
        }
    }
}
