using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1_practice.Practice_2
{
    internal class Bus:Car
    {
        public Bus()
        {
        }

        public void IntroToBus()
        {
            Console.WriteLine("These are Bus Details");
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
