using System;
namespace PetrolStation_v3
{
	public class Logs
	{
        public double litresDispensed { get; set; }
        public int carsCreated { get; set; }
        public int carsServed { get; set; }
        public int carsQueue { get; set; }
        public int carsLeftEarly { get; set; }
        public readonly double fuelCost = 1.5;
        public double cost { get; set; }
        public double commision { get; set; }
        public int avaliablePumps { get; set; }

        public Logs()
		{
            Program.running = false;
            Console.ResetColor();
            Console.WriteLine("\n");
            Console.WriteLine("Closing application...");

            string time = DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss");
            string filePath = "../../../DailyReports/DailyReport_" + time + ".txt";
            System.IO.FileInfo file = new System.IO.FileInfo(filePath);
            file.Directory.Create();

            string content = "Daily report: \n\n" +
            $"Litres dispensed: {Program.litresDispensed} \n" +
            $"Fuel cost: £ {Program.cost}\n" +
            $"1%: £ {Program.commision}\n" +
            $"Vehicles serviced: {Program.carsServed} \n" +
            $"Left early {Program.carsLeftEarly}\n";

            System.IO.File.WriteAllText(file.FullName, content);

        }
	}
}

