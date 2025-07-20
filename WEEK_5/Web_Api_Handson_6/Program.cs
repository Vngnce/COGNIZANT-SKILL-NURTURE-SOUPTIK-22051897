using System;
using System.Threading.Tasks;

namespace KafkaChatApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Kafka Chat App (Producer / Consumer)");
            Console.WriteLine("Choose Mode: 1. Producer   2. Consumer");
            var choice = Console.ReadLine();

            var bootstrapServers = "localhost:9092";
            var topic = "testchat";
            var groupId = "chatgroup";

            if (choice == "1")
            {
                Console.WriteLine("Type messages to send (Ctrl+C to exit):");
                while (true)
                {
                    var message = Console.ReadLine();
                    await KafkaProducer.ProduceMessage(bootstrapServers, topic, message);
                }
            }
            else if (choice == "2")
            {
                KafkaConsumer.ConsumeMessages(bootstrapServers, topic, groupId);
            }
        }
    }
}
