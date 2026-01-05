using boleto.Application.Commands.NewFolder;
using FluentResults;
using MediatR;
using Microsoft.Extensions.Logging;

namespace boleto.Application.Commands.CreatePaymentBatch;

public class CreatePaymentBatchCommandHandler : IRequestHandler<CreatePaymentBatchCommand, Result<int>>
{
    private readonly ILogger<CreatePaymentBatchCommandHandler> _logger;

    public CreatePaymentBatchCommandHandler(ILogger<CreatePaymentBatchCommandHandler> logger)
    {
        _logger = logger;
    }

    public Task<Result<int>> Handle(CreatePaymentBatchCommand request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Handling CreatePaymentBatchCommand for RequesterId: {RequesterId}", request.RequesterId);

        // TODO: Receber os dados do comando e processar a criação do lote de pagamento
        // Adicionar dados no banco de dados
        // Enviar evento ao tópico do Kafka
        return Task.FromResult(1);
    }
}
