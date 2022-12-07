using System;
using Microsoft.VisualBasic.FileIO;
using PetrolStation_v3;

namespace PetrolStation_v3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //var x = new FuelLane();

            bool running = true;
            int runtime = 0;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to Broken Petrol Ltd");
            Console.WriteLine("\n\n");
            Console.ResetColor();

            var security = new Login();

            Vehicle[] x = new Vehicle[3];

            do
            {
                x[0] = new Car();
                x[1] = new Van();
                x[2] = new HVG();
                int randVehicle = random.Next(0, 3);
                Console.WriteLine(x[randVehicle].VehicleInfo);
                runtime += 1;

            //} while (running);
            } while (runtime<5);

            //var Car = new Car();
            //var V = new Vehicle();
            //Console.WriteLine(Car);

        }
    }
}
