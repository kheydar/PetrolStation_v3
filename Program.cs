using System;
using Microsoft.VisualBasic.FileIO;
using PetrolStation_v3;

namespace PetrolStation_v3
{
    class Program
    {
        public static double litresDispensed = 0;
        public static int avaliablePumps = 9;
        public static int carsCreated = 0;
        public static int carsServed = 0;
        public static bool running = true;
        public static bool correctPin;
        public static int carsQueue = 0;
        public static int carsLeftEarly = 0;
        public static readonly double fuelCost = 1.5;
        public static double cost;
        public static double commision;

        

        static void Main(string[] args)
        {
            Random random = new Random();
            //var x = new FuelLane();

            int car = 0;
            int van = 0;
            int hgv = 0;

            bool running = true;
            int runtime = 0;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to Broken Petrol Ltd");
            Console.WriteLine("\n\n");
            Console.ResetColor();

            //var security = new Login();
            //var logs = new Logs();

            //FuelPumps[]  pump  = new FuelPumps[10];
            //for (int i = 1; i <10; i++)
            //{
            //    pump[i] = new FuelPumps(i);
            //}

            do
            {
                Vehicle[] vehicle = new Vehicle[3];
                vehicle[0] = new Car();
                vehicle[1] = new Van();
                vehicle[2] = new HGV();

                int randVehicle = random.Next(0, 3);

                Console.ResetColor();
                Console.WriteLine($"New {vehicle[randVehicle].FuelType} {vehicle[randVehicle].VehicleType} arrived, please select pump or type 'quit' to close the program");
                string userInput = Console.ReadLine();

                switch (vehicle[randVehicle].VehicleType)
                {
                    case "Car":
                        car += 1;
                        break;

                    case "Van":
                        van += 1;
                        break;

                    case "HVG":
                        hgv += 1;
                        break;
                }

                Console.WriteLine($"Cars: {car} \n" +
                    $"Vans: {van} \n" +
                    $"HGVs: {hgv} ");

                

                if (userInput.ToLower() == "quit")
                {
                    var Log = new Logs();
                }

                if (running)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine($"{vehicle[randVehicle].VehicleType} assigned to pump {userInput}, {avaliablePumps} pumps avaliable");
                    Console.WriteLine("\n");
                    Console.WriteLine(new string('#', 80));

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    var output =
                        $"Queue: \n" +
                        $"Total: {carsQueue} \n" +
                        $"Cars: {car}       Vans: {van}       HGVs: {hgv}\n" +
                        //$"Cars: {carsCreated} \n" +
                        $"Litres dispensed: {litresDispensed} \n" +
                        $"Fuel cost: £ {cost}\n" +
                        $"1%: £ {commision}\n" +
                        $"Vehicles serviced: {carsServed} \n" +
                        $"Avaliable pumps: {avaliablePumps} \n" +
                        $"Left early {carsLeftEarly}\n"
                        ;

                    Console.WriteLine(output);
                }
            } while (running);
        }
    }
}
