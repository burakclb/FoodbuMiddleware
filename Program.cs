using System;
using System.Threading.Tasks;
using Tests;

namespace FoodbuMiddleware
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a scenario number to run (e.g., 1, 2, or 3).");
                return;
            }

            string scenario = args[0];
            switch (scenario)
            {
                case "1":
                    Console.WriteLine("Running Scenario 1...");
                    await Scenario1.RunAsync();
                    Console.WriteLine("Scenario 1 Completed.\n");
                    break;
                case "2":
                    Console.WriteLine("Running Scenario 2...");
                    await Scenario2.RunAsync();
                    Console.WriteLine("Scenario 2 Completed.\n");
                    break;
                default:
                    Console.WriteLine("Invalid scenario number. Please provide a valid scenario number (1, 2, or 3).");
                    break;
            }
        }
    }
}
