using boleto.Domain.Models;
using MassTransit;

namespace boleto.Application.Kafka.Interfaces;

public interface IKafkaConsumer
{
    Task Consume(ConsumeContext<BankSlipPaymentBatchRequest> request);
}