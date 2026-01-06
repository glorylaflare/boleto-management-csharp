
using boleto.Application.Kafka.Interfaces;
using boleto.Domain.Models;
using MassTransit;

namespace boleto.Application.Kafka.Consumer;

public class KafkaConsumer : IConsumer<BankSlipPaymentBatchRequest>, IKafkaConsumer
{
    public Task Consume(ConsumeContext<BankSlipPaymentBatchRequest> request) //chegando request corretamente
    {
        return Task.CompletedTask;
    }
}