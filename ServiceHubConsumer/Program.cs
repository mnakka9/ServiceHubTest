using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ServiceHubConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var constr = "<<<<>>>>";
            var client = QueueClient.CreateFromConnectionString(constr);

            client.OnMessage(
                (message) =>
                {

                    WriteLine($"Message with {message.MessageId} is processed, and body is {message.GetBody<string>()}");

                }
                );

            Read();
        }
    }
}
