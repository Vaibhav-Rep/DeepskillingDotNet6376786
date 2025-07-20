using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Confluent.Kafka;
namespace KafkaWinChatSender

{

public class SenderForm : Form

{

private TextBox txtMessage;

private Button btnSend;


public SenderForm()

{

this.Text = "Kafka Chat - Sender";

this.Size = new Size(400, 150);

txtMessage = new TextBox { Location = new Point(20, 20), Size = new Size(250, 25) };

btnSend = new Button { Text = "Send", Location = new Point(280, 20), Size = new Size(75, 25) };

btnSend.Click += BtnSend_Click;

Controls.Add(txtMessage);

Controls.Add(btnSend);

}

private async void BtnSend_Click(object sender, EventArgs e)

{

var message = txtMessage.Text.Trim();

if (!string.IsNullOrEmpty(message))

{

await SendMessage("Sender: " + message);

txtMessage.Clear();

}

}

private async Task SendMessage(string message)

{

var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

using var producer = new ProducerBuilder<Null, string>(config).Build();

await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });

}


[STAThread]

public static void Main()

{

Application.EnableVisualStyles();

Application.SetCompatibleTextRenderingDefault(false);

Application.Run(new SenderForm());

}

}

}