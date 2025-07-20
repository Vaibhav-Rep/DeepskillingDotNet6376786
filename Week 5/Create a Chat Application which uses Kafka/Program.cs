using System;
class Program

{

static async Task Main(string[] args)

{

Console.WriteLine("Type 'p' for producer or 'c' for consumer:");

var choice = Console.ReadLine();


if (choice == "p")

await Producer.Start();

else if (choice == "c")

Consumer.Start();

else

Console.WriteLine("Invalid choice.");

}

}