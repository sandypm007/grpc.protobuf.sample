using Grpc.Net.Client;
using Client.Sample;

class Program
{
    static async Task Main(string[] args)
    {
        // The port number may vary based on your server configuration
        using var channel = GrpcChannel.ForAddress("http://localhost:5003");
        var client = new Greeter.GreeterClient(channel);

        var request = new HelloRequest { Name = "World" };
        var reply = await client.SayHelloAsync(request);

        Console.WriteLine($"Server replied: {reply.Message}");
    }
}
