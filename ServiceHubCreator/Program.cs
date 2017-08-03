using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ServiceHubCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var constr = "<<>>>";
            var client = QueueClient.CreateFromConnectionString(constr);

            var lastKey = ' ';
            var count = 1;
            while(lastKey != 'q')
            {
                var message = $"Message{count++}";
                var bm = new BrokeredMessage(message);
                client.Send(bm);
                WriteLine($"Message sent - {bm.MessageId}");
                lastKey = ReadKey().KeyChar;                
            }
        }
    }
}
