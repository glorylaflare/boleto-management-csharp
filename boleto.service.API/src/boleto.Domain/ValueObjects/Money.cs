namespace boleto.Domain.ValueObjects;

public class Money
{
    
    public decimal Valor { get; set; }
    public string Moeda { get; set; } = "BRL";


    public void Somar(Money outro)
    {
        if (outro.Valor > 0)
        {
            Valor += outro.Valor;
        }
    }
    
    public void Subtrair(Money outro)
    {
        if (outro.Valor > 0)
        {
            Valor -= outro.Valor;
        }
    }
}