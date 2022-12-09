using Grpc.Net.Client;
using gRoom.gRPC.Messages;

using var channel = GrpcChannel.ForAddress("http://localhost:5293");

var client = new Groom.GroomClient(channel);

Console.Write("Enter room name to register:");
var roomName = Console.ReadLine();

var resp = client.RoomRegistration(new RoomRegistrationRequest { RoomName = roomName });
Console.WriteLine($"Room Id: {resp.RoomId}");

Console.Read();
