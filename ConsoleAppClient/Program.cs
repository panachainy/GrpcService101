using Grpc.Net.Client;
using GrpcService101;
using System;
using static GrpcService101.Greeter;

namespace ConsoleAppClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new GreeterClient(channel);

            var request = new HelloRequest
            {
                Name = "your name"
            };

            var helloReply = client.SayHello(request);
            Console.WriteLine(helloReply.Message);
            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}