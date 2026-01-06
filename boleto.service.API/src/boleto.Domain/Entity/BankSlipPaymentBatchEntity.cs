using boleto.Domain.ValueObjects;
using boleto.Shared.Commons;

namespace boleto.Domain.Entity;

public class BankSlipPaymentBatchEntity : EntityBase    
{
    public string RequesterId { get; set; } = string.Empty;
    public List<PaymentTitle> PaymentTitles { get; set; } = new();
    public BatchStatus Status { get; set; } = BatchStatus.PENDING;
}

public enum BatchStatus
{
    PENDING,
    PROCESSING,
    COMPLETED,
    FAILED
}