namespace boleto.Domain.ValueObjects;

public class Documento
{
    
    public TipoDocumento Tipo { get; set; }
    public string Numero { get; set; }
    
    public void Validar()
    {
        // Implementar validação básica do documento
        if (string.IsNullOrWhiteSpace(Numero))
        {
            throw new ArgumentException("Número do documento não pode ser vazio.");
        }
        
        // Adicionar validações específicas para CPF e CNPJ se necessário
    }
    
}
public enum TipoDocumento
{
    CPF,
    CNPJ
}