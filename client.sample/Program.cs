using Grpc.Net.Client;
using Client.Sample;

class Program
{
    static async Task Main(string[] args)
    {
        using var channel = GrpcChannel.ForAddress("http://localhost:5003");
        var client = new Greeter.GreeterClient(channel);

        var request = new HelloRequest { Name = "World" };
        var reply = await client.SayHelloAsync(request);
        Console.WriteLine($"Server replied: {reply.Message}");

        var personClient = new PersonGrpc.PersonGrpcClient(channel);
        var personsResponse = await personClient.GetAllPersonsAsync(new Empty());
        foreach (var person in personsResponse.Persons)
        {
            Console.WriteLine($"{person.Id}: {person.Name} {person.Email}");
        }

        var personResponse = await personClient.GetPersonAsync(new PersonRequest { Id = 1 });
        Console.WriteLine($"{personResponse.Person.Id}: {personResponse.Person.Name} {personResponse.Person.Email}");
    }
}
