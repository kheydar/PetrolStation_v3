using System;
using System.Timers;

namespace PetrolStation_v3
{
    public class Vehicle
    {

        string VehicleFuelType { get; set; }
        string TypeofVehicle { get; set; }
        int VehicleTankSize { get; set; }
        int StartingFuel { get; set; }
        string[]? randFuelType { get; set; }
        string[]? randVehicle { get; set; }
        private static System.Timers.Timer? createVechile;

        Random random = new Random();
        private static System.Timers.Timer refuel;

        public Vehicle(string vehicleFuelType, string typeofVehicle, int vehicleTankSize, int startingFuel)
        {
            VehicleFuelType = vehicleFuelType;
            TypeofVehicle = typeofVehicle;
            VehicleTankSize = vehicleTankSize;
            StartingFuel = startingFuel;

            int newVehicle = random.Next(1500, 2200);
            createVechile = new System.Timers.Timer();
            createVechile.Interval = newVehicle;
            createVechile.Enabled = true;
            createVechile.AutoReset = false;
            createVechile.Elapsed += VehicleTimer;
            createVechile.Start();
        }

        public Vehicle()
        {
            randFuelType = new string[] { "Diesel", "Petrol", "LPG" };
            VehicleFuelType = randFuelType[random.Next(0, 2)];
            randVehicle = new string[] { "Car", "Van", "HVG" };
            TypeofVehicle = randVehicle[random.Next(0, 2)];
            VehicleTankSize = random.Next(50, 150);
            StartingFuel = random.Next(0, 150);

            int newVehicle = random.Next(1500, 2200);
            createVechile = new System.Timers.Timer();
            createVechile.Interval = newVehicle;
            createVechile.Enabled = true;
            createVechile.AutoReset = false;
            createVechile.Elapsed += VehicleTimer;
            createVechile.Start();

            int refuelTime = random.Next(3000, 5000);
            refuel = new System.Timers.Timer();
            refuel.Interval = refuelTime;
            refuel.Enabled = true;
            refuel.AutoReset = false;
            refuel.Elapsed += RefuelTimer;
            refuel.Start();
        }

        static void VehicleTimer(Object source, ElapsedEventArgs e)
        {
            Random random = new Random();
            int newVehicle = random.Next(1500, 2200);
            createVechile.Interval = newVehicle;

        }   

        static void RefuelTimer(Object source, ElapsedEventArgs e)
        {
            Random random = new Random();
            int refuelTime = random.Next(3000, 5000);
            refuel.Interval = refuelTime;

            double fuelDispensed = 1.5 * (refuelTime / 1000);
            
        }

        public virtual string VehicleInfo
        {
            get => $"Vehicle is a {TypeofVehicle} that uses {VehicleFuelType} " +
                $"with a tank size of {VehicleTankSize} and with a starting fuel of {StartingFuel} " +
                $"Vechile was created after {createVechile.Interval}";
        }

    }
}

