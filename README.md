# FoodbuMiddleware

This project implements a middleware system for processing customer orders in a food service context. It prioritizes orders based on preparation times and arrival times, ensuring efficient order handling.

## Project Structure

- **Middleware**: Contains the main middleware logic for processing orders.
- **Tests**: Contains test scenarios to simulate different order arrival times and conditions.
- **Data**: Contains the `orders.json` file with sample orders for testing purposes.

## Prerequisites

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio Code](https://code.visualstudio.com/)

## Setup Instructions

1. Clone the repository:

    ```bash
    git clone https://github.com/yourusername/FoodbuMiddleware.git
    cd FoodbuMiddleware
    ```

2. Restore the required packages:

    ```bash
    dotnet restore
    ```

3. Build the project:

    ```bash
    dotnet build
    ```

## Running the Test Scenarios

1. **Scenario 1**: Orders arriving every 1 second.

    ```bash
    dotnet run -- 1
    ```

2. **Scenario 2**: Orders arriving randomly, some every 1 second, some every 30 seconds.

    ```bash
    dotnet run -- 2
    ```

## Project Files

- `Program.cs`: Main entry point of the application.
- `Middleware/Middleware.cs`: Core logic for processing and prioritizing orders.
- `Middleware/Order.cs`: Defines the structure of an order.
- `Tests/Scenario1.cs`: Test scenario where orders arrive every 1 second.
- `Tests/Scenario2.cs`: Test scenario where orders arrive at varying intervals.
- `Data/orders.json`: Sample orders for testing.

## How to Modify the Test Scenarios

1. Open the `Tests` folder.
2. Modify `Scenario1.cs` or `Scenario2.cs` as needed to change the order arrival logic or the number of orders.
3. Save the changes and rebuild the project:

    ```bash
    dotnet build
    ```

4. Run the modified test scenario:

    ```bash
    dotnet run -- [scenario_number]
    ```

## Notes

- Ensure that the `orders.json` file contains diverse sample orders to fully test the system's prioritization logic.
- This middleware is designed to integrate seamlessly with both UI and backend systems, ensuring robust and efficient order processing.

For any issues or contributions, please open a pull request or an issue on GitHub.

Running Scenario 1...
Order 27 with tag Order-27 added at 6/23/2024 2:18:10 PM with preparation time 120 seconds.
Order 27 with tag Order-27 is being processed.
Order 30 with tag Order-30 added at 6/23/2024 2:18:11 PM with preparation time 200 seconds.
Order 9 with tag Order-9 added at 6/23/2024 2:18:12 PM with preparation time 90 seconds.
Order 11 with tag Order-11 added at 6/23/2024 2:18:13 PM with preparation time 210 seconds.
Order 3 with tag Order-3 added at 6/23/2024 2:18:14 PM with preparation time 210 seconds.
Order 19 with tag Order-19 added at 6/23/2024 2:18:15 PM with preparation time 80 seconds.
Order 15 with tag Order-15 added at 6/23/2024 2:18:16 PM with preparation time 130 seconds.
Order 22 with tag Order-22 added at 6/23/2024 2:18:17 PM with preparation time 90 seconds.
Order 18 with tag Order-18 added at 6/23/2024 2:18:18 PM with preparation time 170 seconds.
Order 14 with tag Order-14 added at 6/23/2024 2:18:19 PM with preparation time 160 seconds.
Scenario 1 Completed.

Running Scenario 2...
Order 22 with tag Order-22 added at 6/23/2024 2:19:08 PM with preparation time 90 seconds.
Order 22 with tag Order-22 is being processed.
Order 23 with tag Order-23 added at 6/23/2024 2:19:09 PM with preparation time 120 seconds.
Order 2 with tag Order-2 added at 6/23/2024 2:19:10 PM with preparation time 90 seconds.
Order 21 with tag Order-21 added at 6/23/2024 2:19:11 PM with preparation time 170 seconds.
Order 19 with tag Order-19 added at 6/23/2024 2:19:12 PM with preparation time 80 seconds.
Order 10 with tag Order-10 added at 6/23/2024 2:19:42 PM with preparation time 120 seconds.
Order 29 with tag Order-29 added at 6/23/2024 2:19:43 PM with preparation time 90 seconds.
Order 30 with tag Order-30 added at 6/23/2024 2:19:44 PM with preparation time 200 seconds.
Order 5 with tag Order-5 added at 6/23/2024 2:19:45 PM with preparation time 130 seconds.
Order 27 with tag Order-27 added at 6/23/2024 2:19:46 PM with preparation time 120 seconds.
Order 14 with tag Order-14 added at 6/23/2024 2:20:16 PM with preparation time 160 seconds.
Order 16 with tag Order-16 added at 6/23/2024 2:20:17 PM with preparation time 130 seconds.
Order 13 with tag Order-13 added at 6/23/2024 2:20:18 PM with preparation time 170 seconds.
Order 8 with tag Order-8 added at 6/23/2024 2:20:19 PM with preparation time 200 seconds.
Order 4 with tag Order-4 added at 6/23/2024 2:20:20 PM with preparation time 160 seconds.
Order 22 with tag Order-22 and preparation time 90 seconds notified to main system.
Order 23 with tag Order-23 is being processed.
Order 28 with tag Order-28 added at 6/23/2024 2:20:50 PM with preparation time 160 seconds.
Order 17 with tag Order-17 added at 6/23/2024 2:20:51 PM with preparation time 160 seconds.
Order 18 with tag Order-18 added at 6/23/2024 2:20:52 PM with preparation time 170 seconds.
Order 20 with tag Order-20 added at 6/23/2024 2:20:53 PM with preparation time 170 seconds.
Order 15 with tag Order-15 added at 6/23/2024 2:20:54 PM with preparation time 130 seconds.
Order 9 with tag Order-9 added at 6/23/2024 2:21:24 PM with preparation time 90 seconds.
Order 25 with tag Order-25 added at 6/23/2024 2:21:25 PM with preparation time 130 seconds.
Order 6 with tag Order-6 added at 6/23/2024 2:21:26 PM with preparation time 90 seconds.
Order 1 with tag Order-1 added at 6/23/2024 2:21:27 PM with preparation time 210 seconds.
Order 12 with tag Order-12 added at 6/23/2024 2:21:28 PM with preparation time 80 seconds.
Order 24 with tag Order-24 added at 6/23/2024 2:21:58 PM with preparation time 160 seconds.
Order 26 with tag Order-26 added at 6/23/2024 2:21:59 PM with preparation time 90 seconds.
Order 3 with tag Order-3 added at 6/23/2024 2:22:00 PM with preparation time 210 seconds.
Order 11 with tag Order-11 added at 6/23/2024 2:22:01 PM with preparation time 210 seconds.
Order 7 with tag Order-7 added at 6/23/2024 2:22:02 PM with preparation time 120 seconds.
Scenario 2 Completed.