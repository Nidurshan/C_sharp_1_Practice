using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1_practice.Practice_1
{
    class WorkingPerson:Person
    {
        public string job;
        public int salary;
        public string worklocation;

        public WorkingPerson() 
        {
        }

        public override void SetData()
        {
            base.SetData();

            Console.Write("Enter Your Job: ");
            job = Console.ReadLine();

            Console.Write("Enter Your Salary: ");
            salary = int.Parse(Console.ReadLine());

            Console.Write("Enter Your Work Location: ");
            worklocation = Console.ReadLine();
        }

        public override void GetData()
        {
            base.GetData();

            Console.WriteLine("Job: " + job);
            Console.WriteLine("Salary: Rs." + salary);
            Console.WriteLine("Work Location: " + worklocation);
        }
    }
}
