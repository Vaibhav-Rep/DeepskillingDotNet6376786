using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Confluent.Kafka;
namespace KafkaWinChatReceiver

{

public class ReceiverForm : Form

{

private ListBox lstMessages;


public ReceiverForm()

{

this.Text = "Kafka Chat - Receiver";

this.Size = new Size(400, 500);


lstMessages = new ListBox

{

Location = new Point(20, 20),

Size = new Size(340, 400)

};


Controls.Add(lstMessages);

StartConsumer();

}


private void StartConsumer()

{

Task.Run(() =>

{

var config = new ConsumerConfig

{

GroupId = "receiver-group",

BootstrapServers = "localhost:9092",

AutoOffsetReset = AutoOffsetReset.Earliest

};


using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();

consumer.Subscribe("chat-topic");


while (true)

{

var result = consumer.Consume(CancellationToken.None);

Invoke((MethodInvoker)(() =>

{

lstMessages.Items.Add(result.Message.Value);

}));

}

});

}


[STAThread]

public static void Main()

{

Application.EnableVisualStyles();

Application.SetCompatibleTextRenderingDefault(false);

Application.Run(new ReceiverForm());

}

}

}