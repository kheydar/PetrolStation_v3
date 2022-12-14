using System;
namespace PetrolStation_v3
{
	public class HGV: Vehicle
	{
        private readonly Random random = new Random();
        private int startingFuel;
        string[]? FuelType { get; set; }
        private string? VehicleFuelType { get; set; }

        public HGV(int startingFuel, int vehicleTankSize = 150, string vehicleFuelType = "Diesel", string typeofVehicle = "HGV")
            : base(vehicleFuelType, typeofVehicle, vehicleTankSize, startingFuel)

        {


        }

        public HGV(int vehicleTankSize = 150, string vehicleFuelType = "Diesel", string typeofVehicle = "HGV")
           : base()

        {
            Random random = new Random();
            startingFuel = random.Next(0, 75);
        }

        //public override string VehicleInfo
        //{
        //    get => $"Vehicle is a HGV running on Diesel with a tank size of 150 and with a starting fuel of {startingFuel}";
        //}
    }
}

