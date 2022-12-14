using System;
using System.Timers;
using System.Collections.Generic;

namespace PetrolStation_v3
{
    public class FuelPumps
    {
        Random random = new Random();
        int pumpNumber { get; set; }
        bool pumpAvaliable { get; set; }
        string pumpStatus { get; set; }
        static System.Timers.Timer refuel;

        public FuelPumps(int i)
        {
            pumpNumber += i;
            pumpAvaliable = true;
            pumpStatus = "Free";
            Refuel();
        }

        public void Refuel()
        {
            Random random = new Random();
            int refuelTime = random.Next(3000, 5000);
            refuel = new System.Timers.Timer();
            refuel.Interval = refuelTime;
            refuel.AutoReset = false;
            refuel.Elapsed += RefuelTimer;

            refuel.Enabled = true;
            pumpAvaliable = false;
            pumpStatus = "Busy";
        }

        //public void CheckPump(bool avaliable)
        //{
        //    if (!avaliable)
        //    {
        //        refuel.Enabled = true;
        //        pumpAvaliable = false;
        //        pumpStatus = "Busy";
        //    }
        //}


        private void RefuelTimer(Object source, ElapsedEventArgs e)
        {
            Logs Logs = new Logs();
            Random random = new Random();
            int refuelTime = random.Next(3000, 5000);
            refuel.Interval = refuelTime;

            double fuelDispensed = 1.5 * (refuelTime / 1000);
            Logs.litresDispensed += fuelDispensed;
            Logs.cost = Logs.litresDispensed * Logs.fuelCost;
            Logs.commision = Logs.cost * 0.01;
            Logs.carsServed += 1;

            if (Logs.avaliablePumps < 9)
            {
                Logs.avaliablePumps += 1;
            }

            if (Logs.carsQueue > 0)
            {
                Logs.carsQueue -= 1;
            }

            pumpAvaliable = true;
            pumpStatus = "Free";
        }
    }
}


