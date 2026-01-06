using boleto.Shared.Events;
using MassTransit;

namespace boleto.API.Helpers;

public static class MassTransitHelper
{
    public static IServiceCollection AddMassTransitHelper(this IServiceCollection services)
    {
        services.AddMassTransit(x =>
        {
            x.UsingInMemory();

            x.AddRider(rider =>
            {
                rider.AddProducer<BankSlipPaymentBatchEvent>("bank-slip-payment-batch");

                rider.UsingKafka((context, k) =>
                {
                    k.Host("localhost:29092");
                });
            });
        });

        return services;
    }
}
