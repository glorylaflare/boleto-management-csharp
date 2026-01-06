using boleto.Domain.Entity;
using boleto.Domain.ValueObjects;
using boleto.Shared.Events;
using FluentResults;
using FluentValidation;
using MassTransit;
using MediatR;
using Microsoft.Extensions.Logging;

namespace boleto.Application.Commands.CreatePaymentBatch;

public class CreatePaymentBatchCommandHandler : IRequestHandler<CreatePaymentBatchCommand, Result<int>>
{
    private readonly ILogger<CreatePaymentBatchCommandHandler> _logger;
    private readonly IValidator<CreatePaymentBatchCommand> _validator;
    private readonly ITopicProducer<BankSlipPaymentBatchEvent> _producer;

    public CreatePaymentBatchCommandHandler(ILogger<CreatePaymentBatchCommandHandler> logger, IValidator<CreatePaymentBatchCommand> validator, ITopicProducer<BankSlipPaymentBatchEvent> producer)
    {
        _logger = logger;
        _validator = validator;
        _producer = producer;
    }

    public async Task<Result<int>> Handle(CreatePaymentBatchCommand request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Handling CreatePaymentBatchCommand for RequesterId: {RequesterId}", request.RequesterId);

        var validationResult = await _validator.ValidateAsync(request, cancellationToken);
        if (!validationResult.IsValid)
        {
            _logger.LogWarning("Validation failed for CreatePaymentBatchCommand for RequesterId: {RequesterId}", request.RequesterId);
            return Result.Fail<int>(validationResult.Errors.Select(e => e.ErrorMessage));
        }

        try
        {
            var batchPaymentTitles = new BankSlipPaymentBatchEntity
            {
                RequesterId = request.RequesterId,
                PaymentTitles = request.PaymentTitles.Select(pt => new PaymentTitle
                {
                    PaymentId = pt.PaymentId,
                    PaymentCode = pt.PaymentCode,
                    Amount = pt.Amount
                }).ToList()
            };

            // Proceed with creating the payment batch

            var bspEvent = new BankSlipPaymentBatchEvent
            {
                BatchId = Guid.NewGuid(),
                Data = request.PaymentTitles.Select(pt => new PaymentTitleEvent
                {
                    PaymentId = pt.PaymentId,
                    PaymentCode = pt.PaymentCode,
                    Amount = pt.Amount,
                    Status = 0 // Assuming 0 is the initial status
                }).ToList(),
                Status = 0, // Assuming 0 is the initial status
                CreatedAt = DateTime.UtcNow,
                CorrelationId = Guid.NewGuid(),
            };

            await _producer.Produce(
                message: bspEvent, 
                cancellationToken: cancellationToken
            );

            return Result.Ok(1); // Return appropriate result
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while handling CreatePaymentBatchCommand for RequesterId: {RequesterId}", request.RequesterId);
            return Result.Fail<int>("An error occurred while creating the payment batch.");
        }
    }
}
