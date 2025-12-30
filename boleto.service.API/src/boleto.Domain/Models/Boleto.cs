using boleto.Domain.ValueObjects;

namespace DefaultNamespace;

public class Boleto
{
    
    public Guid Id { get; set; }
    public string LinhaDigitavel { get; set; }
    public string CodigoBarras { get; set; }
    public string NossoNumero { get; set; }
    public string NumeroDocumento { get; set; }
    
    
    public Banco Banco { get; set; }
    public string Agencia { get; set; }
    public string Conta { get; set; }
    public string Carteira { get; set; }
    
    public DateTime DataEmissao { get; set; }
    public DateTime DataVencimento { get; set; }
    public DateTime? DataProcessamento { get; set; }
    public DateTime? DataPagamento { get; set; }
    
    public Money ValorOriginal { get; set; }
    public Money ValorDesconto { get; set; }
    public Money ValorJuros { get; set; }
    public Money ValorMulta { get; set; }
    public Money ValorOutrosAcrescimos { get; set; }
    public Money ValorOutrasDeducoes { get; set; }
    public Money ValorFinalCalculado { get; set; }
    
    //public Beneficiario Beneficiario { get; set; }
    //public Pagador Pagador { get; set; }
    
    public BoletoStatus Status { get; set; }
    public int Ciclo { get; set; }
    public int TentativaProcessamento { get; set; }
    public bool ProcessadoEmLote { get; set; }
    
    public DateTime CriadoEm { get; set; }
    public DateTime AtualizadoEm { get; set; }
    public byte[] Versao { get; set; }
    
    
    
}