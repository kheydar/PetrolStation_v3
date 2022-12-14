using System;
namespace PetrolStation_v3
{
    public class FuelLane
    {
        public FuelLane()
        {
            for (int lane = 1; lane <= 3; lane++)
            {
                Console.WriteLine($"Fuel lane {lane} created");

                for (int pump = 1; pump <= 3; pump++)
                {
                    Console.WriteLine($"Pump {pump} created");
                }
            }


        }
    }
}

