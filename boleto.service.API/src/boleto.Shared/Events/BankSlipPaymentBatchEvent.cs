namespace boleto.Shared.Events;

public class BankSlipPaymentBatchEvent
{
    public Guid BatchId { get; set; }
    public List<PaymentTitleEvent> Data { get; set; } = new();
    public int Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid CorrelationId { get; set; }
}

public class PaymentTitleEvent
{
    public Guid PaymentId { get; set; }    
    public string PaymentCode { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public int Status { get; set; }
}