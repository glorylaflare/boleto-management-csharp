namespace boleto.Domain.ValueObjetcs;

public class PaymentTitle
{
    public Guid PaymentId { get; set; }
    public string PaymentCode { get; set; } = string.Empty;
    public decimal Amount { get; set; }
}
