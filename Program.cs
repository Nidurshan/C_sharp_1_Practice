using C_sharp_1_practice.Practice_1;
using C_sharp_1_practice.Practice_2;
using C_sharp_1_practice.Practice_3;

namespace C_sharp_1_practice
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            //Person person = new Person();
            //person.SetData();
            //person.GetData();

            //Console.WriteLine("---------------------------------------");

            //Person student = new Student();
            //student.SetData();
            //student.GetData();

            //Console.WriteLine("---------------------------------------");

            //Person teacher = new WorkingPerson();
            //teacher.SetData();
            //teacher.GetData();

            //Console.WriteLine("---------------------------------------");

            //Vehicle vehicle = new Vehicle();
            //vehicle.SetInput();
            //vehicle.GetOutput();

            //Console.WriteLine("---------------------------------------");

            //Car car = new Car();
            //car.IntroToCar();
            //car.SetInput();
            //car.GetOutput();

            //Console.WriteLine("---------------------------------------");

            //Bike bike = new Bike();
            //bike.IntroToBike();
            //bike.SetInput();
            //bike.GetOutput();

            //Console.WriteLine("---------------------------------------");

            //Bus bus = new Bus();
            //bus.IntroToBus();
            //bus.SetInput();
            //bus.GetOutput();

            Console.WriteLine("---------------------------------------");

            Shape squre = new Squre();
            squre.SetValues();
            squre.Find_Area();

            Shape rectrangle = new Rectrangle();
            rectrangle.SetValues();  
            rectrangle.Find_Area();

            Console.WriteLine("---------------------------------------");
        }
    }
}