using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;

namespace TestServiceBusReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Endpoint=sb://xxxservicebus1.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=p/bAbB/B1UzskSpeVeEsmwjH+TS/Fs2kGgyFlmcomxA=";
            var queueName = "Queue1";
            QueueClient client = QueueClient.CreateFromConnectionString(connectionString, queueName);

            client.OnMessage(message =>
            {
                Console.WriteLine(String.Format("Message body: {0}", message.GetBody<String>()));
                Console.WriteLine(String.Format("Message id: {0}", message.MessageId));
            });

            Console.ReadLine();
        }
    }
}
