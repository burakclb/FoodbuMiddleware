using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Middleware;
using Newtonsoft.Json;

namespace Tests
{
    public class Scenario1
    {
        public static async Task RunAsync()
        {
            Middleware.Middleware middleware = new Middleware.Middleware();

            // Load orders from JSON file
            var orders = LoadOrdersFromJson();

            Random random = new Random();
            HashSet<int> usedOrderIndexes = new HashSet<int>();

            // Scenario 1: Orders arriving every 1 second with random selection from JSON orders
            for (int i = 1; i <= 10; i++) // Choose 10 random orders
            {
                int orderIndex;
                do
                {
                    orderIndex = random.Next(orders.Count);
                } while (usedOrderIndexes.Contains(orderIndex));

                usedOrderIndexes.Add(orderIndex);

                var order = orders[orderIndex];
                await middleware.AddOrderAsync(order.OrderId, DateTime.Now, order.Items, order.Tag);
                await Task.Delay(1000); // 1 second delay between orders
            }

            // Wait for a while to process all orders
            await Task.Delay(5000);

            // Stop processing orders
            middleware.StopProcessingOrders();
        }

        // Method to load orders from JSON file
        private static List<Order> LoadOrdersFromJson()
        {
            // Corrected file path to the JSON file
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../Data/orders.json");
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Order>>(json) ?? new List<Order>();
        }
    }
}
