# gRPC Protobuf Sample Project

This is a sample project demonstrating the use of gRPC with Protobuf for communication between client and server, and Entity Framework Core for an in-memory database. The project includes a simple gRPC service that can create, read, and list persons.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio Code](https://code.visualstudio.com/) (or any other preferred IDE)
- [gRPC tools](https://grpc.io/docs/protoc-installation/)

## Project Structure
```
grpc-protobuf-sample/
├── Protos/
│ └── person.proto
├── Data/
│ └── AppDbContext.cs
│ └── SeedData.cs
├── Models/
│ └── Person.cs
├── Services/
│ └── PersonService.cs
│ └── GreeterService.cs
├── Program.cs
└── README.md
```
## Clone and Run the Projects

1. **Clone the Repository:**

   ```sh
   git clone https://github.com/yourusername/grpc-protobuf-sample.git
   cd grpc-protobuf-sample
   ```
   
2. **Install Dependencies:**

    Ensure you have the [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) installed.

3. **Restore NuGet Packages for the server:**
   
   ```
   cd server.sample
   dotnet restore
   ```
   
4. **Build and Run the server:**

   ```
   dotnet run
   ```

5. **Restore NuGet Packages for the client:**
   
   ```
   cd ../client.sample
   dotnet restore
   ```
   
6. **Build and Run the client:**

   ```
   dotnet run
   ```
