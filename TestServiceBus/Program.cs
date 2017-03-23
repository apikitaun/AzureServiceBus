using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;

namespace TestServiceBus
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Endpoint=sb://xxxservicebus1.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=p/bAbB/B1UzskSpeVeEsmwjH+TS/Fs2kGgyFlmcomxA=";
            var queueName = "Queue1";
            QueueClient client = QueueClient.CreateFromConnectionString(connectionString, queueName);
            BrokeredMessage message = new BrokeredMessage("This is one message from Sdt Service Bus client ["+Guid.NewGuid()+"]");
            client.Send(message);
            Console.WriteLine("Message Sent");
            Console.ReadLine();
        }
    }
}
