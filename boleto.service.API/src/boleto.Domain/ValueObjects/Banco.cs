namespace boleto.Domain.ValueObjects;

public class Banco
{
    
    public string Codigo { get; set; }
    public string Nome { get; set; }
    
    public void ValidaLinhaDigitavel(string linhaDigitavel)
    {
        // Implementar a lógica de validação da linha digitável específica para este banco
    }
    
    public void ValidaCodigoBarras(string codigoBarras)
    {
        // Implementar a lógica de validação do código de barras específica para este banco
    }
}