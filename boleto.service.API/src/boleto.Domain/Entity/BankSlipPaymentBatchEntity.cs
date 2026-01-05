using boleto.Domain.ValueObjetcs;
using boleto.Shared.Base;

namespace boleto.Domain.Entity;

public class BankSlipPaymentBatchEntity : EntityBase    
{
    public Guid RequesterId { get; set; }
    public List<PaymentTitle> PaymentTitles { get; set; } = new();
    public BatchStatus Status { get; set; }
}

public enum BatchStatus
{
    PENDING,
    PROCESSING,
    COMPLETED,
    FAILED
}