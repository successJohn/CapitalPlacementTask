# CapitalPlacementTask

This repository contains a .NET 6 application developed using clean architecture principles and utilizing Azure Cosmos DB as a NoSQL database.

## Technologies Used

- **.NET 6:**
- **Clean Architecture:** The project follows the clean architecture principles, ensuring a separation of concerns and maintainability of the codebase.
- **Azure Cosmos DB:** A Microsoft NoSQL database for this project.
- **xUnit:** Testing framework for writing and running unit tests in the project.

## Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Azure Cosmos DB Account](https://azure.microsoft.com/en-us/services/cosmos-db/) or [Azure Cosmos DB Emulator](https://docs.microsoft.com/en-us/azure/cosmos-db/local-emulator)

## Installation and Setup

1. Clone the repository to your local machine:

   ```
   git clone <repository-url>
   ```

2. Open the solution in your IDE

3. Configure Azure Cosmos DB Or Azure Local Emulator
   emulator installation instructions can be found [here](https://docs.microsoft.com/en-us/azure/cosmos-db/local-emulator).
   - Obtain the following details from your Azure Cosmos DB account or emulator: `EndpointUri`, `DatabaseName`, and `PrimaryKey`.
   - Add these details to the `appsettings.json` file under the `"CosmosDbSettings"` section in app.Development.Json file:

   ```json
   "CosmosDbSettings": {
     "EndpointUri": "<Your-EndpointUri>",
     "DatabaseName": "<Your-DatabaseName>",
     "PrimaryKey": "<Your-PrimaryKey>"
   }
   ```


## Running Tests

Unit tests for this project are written using xUnit. To run the tests, use the following command in the terminal:

```bash
dotnet test
```
## License

This project is licensed under the [MIT License](LICENSE). Feel free to use, modify, and distribute the code as per the license terms.

---
