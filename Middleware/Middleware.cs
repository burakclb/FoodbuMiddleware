using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Middleware
{
    public class Middleware
    {
        private ConcurrentQueue<Order> orderQueue = new ConcurrentQueue<Order>();
        private List<Order> orders = new List<Order>();
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        public Middleware()
        {
            // Start processing the queue in a separate task
            Task.Run(() => ProcessOrderQueueAsync(cancellationTokenSource.Token));
        }

        // Asynchronous function to add an order
        public async Task AddOrderAsync(int orderId, DateTime orderTime, List<string> items, string tag)
        {
            int preparationTime = CalculatePreparationTime(items);
            var order = new Order
            {
                OrderId = orderId,
                Items = items,
                Tag = tag
            };

            orderQueue.Enqueue(order);
            Console.WriteLine($"Order {orderId} with tag {tag} added at {orderTime} with preparation time {preparationTime} seconds.");
            await Task.CompletedTask;
        }

        // Function to calculate preparation time
        private int CalculatePreparationTime(List<string> items)
        {
            int preparationTime = 0;
            foreach (var item in items)
            {
                switch (item)
                {
                    case "Rice":
                        preparationTime += 80; // Example preparation time for Rice
                        break;
                    case "Beef Doner":
                        preparationTime += 40; // Example preparation time for Beef Doner
                        break;
                    case "Meatball":
                        preparationTime += 40; // Example preparation time for Meatball
                        break;
                    case "Falafel":
                        preparationTime += 50; // Example preparation time for Falafel
                        break;
                    case "Chicken Doner":
                        preparationTime += 40; // Example preparation time for Chicken Doner
                        break;
                    default:
                        preparationTime += 30; // Example preparation time for other items
                        break;
                }
            }
            return preparationTime;
        }

        // Asynchronous function to process order queue
        private async Task ProcessOrderQueueAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                if (orderQueue.TryDequeue(out var order))
                {
                    orders.Add(order);
                    Console.WriteLine($"Order {order.OrderId} with tag {order.Tag} is being processed.");
                    await Task.Delay(CalculatePreparationTime(order.Items) * 1000); // Simulate preparation time
                    await NotifyToMainSystemAsync(order);
                }
                else
                {
                    await Task.Delay(1000); // Wait before checking the queue again
                }
            }
        }

        // Asynchronous function to prioritize orders and notify the main system
        public async Task NotifyOrdersAsync()
        {
            var prioritizedOrders = orders.OrderBy(o => CalculatePreparationTime(o.Items)).ThenBy(o => o.OrderId).ToList();

            List<Task> notificationTasks = new List<Task>();

            foreach (var order in prioritizedOrders)
            {
                notificationTasks.Add(NotifyToMainSystemAsync(order));
            }

            await Task.WhenAll(notificationTasks);
        }

        // Asynchronous function to notify the main system (example)
        private async Task NotifyToMainSystemAsync(Order order)
        {
            // Notify the main system here
            Console.WriteLine($"Order {order.OrderId} with tag {order.Tag} and preparation time {CalculatePreparationTime(order.Items)} seconds notified to main system.");
            await Task.CompletedTask;
        }

        // Stop processing orders
        public void StopProcessingOrders()
        {
            cancellationTokenSource.Cancel();
        }
    }
}
