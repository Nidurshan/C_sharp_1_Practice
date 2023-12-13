using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1_practice.Practice_1
{
    public class Person
    {
        public string name;
        public int age;
        public string city;

        public Person()
        {
        }

        public virtual void SetData()
        {
            Console.Write("Enter Your Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Your Age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter Your City: ");
            city = Console.ReadLine();
        }

        public virtual void GetData()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("City: " + city);
        }
    }
}
