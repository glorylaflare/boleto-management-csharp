using FluentResults;
using MediatR;

namespace boleto.Application.Commands.CreatePaymentBatch;

public class CreatePaymentBatchCommand : IRequest<Result<int>>
{
    public string RequesterId { get; set; } = string.Empty;
    public List<BatchPaymentTitle> PaymentTitles { get; set; } = new();
} 

public class BatchPaymentTitle
{
    public Guid PaymentId { get; set; }
    public string PaymentCode { get; set; } = string.Empty;
    public decimal Amount { get; set; }
}