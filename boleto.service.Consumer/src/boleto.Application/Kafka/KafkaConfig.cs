using boleto.Application.Kafka.Consumer;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;

namespace boleto.Application.Kafka;

public class KafkaConfig
{
    public void ConfigConsumer()
    {
        var services = new ServiceCollection();

        services.AddMassTransit(x =>
        {
            x.UsingInMemory();

            x.AddRider(rider =>
            {
                rider.AddConsumer<KafkaConsumer>();

                rider.UsingKafka((context, k) =>
                {
                    k.Host("localhost:9092");

                    k.TopicEndpoint<String, String>("bank-slip-payment-batch", "consumer-batch-processor",
                        e => { e.ConfigureConsumer<KafkaConsumer>(context); });
                });
            });
        });
    }
}