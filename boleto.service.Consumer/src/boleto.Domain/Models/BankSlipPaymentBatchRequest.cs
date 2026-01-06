using boleto.Domain.ValueObjects;

namespace boleto.Domain.Models;

public class BankSlipPaymentBatchRequest
{
    public Guid BatchId { get; set; }
    public string RequesterId { get; set; }
    public List<BatchPaymentTitle> Items { get; set; }
    public BatchStatus Status { get; set; }
    public DateTime CreatedAt { get; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; }
}

public enum BatchStatus
{
    PENDING,
    PROCESSING,
    COMPLETED,
    FAILED
}