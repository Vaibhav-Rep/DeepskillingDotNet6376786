using System;
using Confluent.Kafka;
class Consumer

{

public static void Start()

{

var config = new ConsumerConfig

{

BootstrapServers = "localhost:9092",

GroupId = "chat-group",

AutoOffsetReset = AutoOffsetReset.Earliest

};

using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();

consumer.Subscribe("chat-topic");

Console.WriteLine("Waiting for messages... (Ctrl+C to exit)");

try

{

while (true)

{

var cr = consumer.Consume();

Console.WriteLine($"Received: {cr.Value}");

}

}

catch (OperationCanceledException)

{

consumer.Close();

}

}

}