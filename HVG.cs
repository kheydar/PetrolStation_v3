using System;
namespace PetrolStation_v3
{
	public class HVG: Vehicle
	{
        private readonly Random random = new Random();
        private int startingFuel;
        private string[]? FuelType { get; set; }
        private string? VehicleFuelType { get; set; }

        public HVG(int startingFuel, int vehicleTankSize = 150, string vehicleFuelType = "Diesel", string typeofVehicle = "HVG")
            : base(vehicleFuelType, typeofVehicle, vehicleTankSize, startingFuel)

        {


        }

        public HVG(int vehicleTankSize = 150, string vehicleFuelType = "Diesel", string typeofVehicle = "HVG")
           : base()

        {
            Random random = new Random();
            startingFuel = random.Next(0, 75);
        }

        public override string VehicleInfo
        {
            get => $"Vehicle is a HVG running on Diesel with a tank size of 150 and with a starting fuel of {startingFuel}";
        }
    }
}

