using System;
namespace PetrolStation_v3
{
	public class Van: Vehicle
	{
        private readonly Random random = new Random();
        private int startingFuel;
        private string[]? FuelType { get; set; }
        private string? VehicleFuelType { get; set; }

        public Van(string vehicleFuelType, int startingFuel, int vehicleTankSize = 80, string typeofVehicle = "Van")
            : base(vehicleFuelType, typeofVehicle, vehicleTankSize, startingFuel)
        {

		}

        public Van(int vehicleTankSize = 80, string typeofVehicle = "Van")
           : base()

        {
            Random random = new Random();
            startingFuel = random.Next(0, 40);
            FuelType = new string[] { "Diesel", "LPG" };
            VehicleFuelType = FuelType[random.Next(0, 2)];
        }

        public override string VehicleInfo
        {
            get => $"Vehicle is a Van running on {VehicleFuelType} with a tank size of 80 and with a starting fuel of {startingFuel}";
        }
    }
}

