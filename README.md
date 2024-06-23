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

