using System;
using Confluent.Kafka;

namespace KafkaChatApp
{
    public class KafkaConsumer
    {
        public static void ConsumeMessages(string bootstrapServers, string topic, string groupId)
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = bootstrapServers,
                GroupId = groupId,
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            consumer.Subscribe(topic);

            Console.WriteLine($"Subscribed to topic {topic}. Waiting for messages...");

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
}
