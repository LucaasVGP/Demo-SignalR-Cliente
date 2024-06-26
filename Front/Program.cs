using Microsoft.AspNetCore.SignalR.Client;

var connection = new HubConnectionBuilder()
		   .WithUrl("https://localhost:7284/signalrhub")
		   .Build();

connection.On<string>("ReceiveMessage", (message) =>
{
	Console.WriteLine($"Recebido: {message}");
});

await connection.StartAsync();

Console.WriteLine("Conectado ao servidor SignalR. Pressione qualquer tecla para sair...");
Console.ReadKey();