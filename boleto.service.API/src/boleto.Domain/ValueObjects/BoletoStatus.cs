namespace boleto.Domain.ValueObjects;

public enum BoletoStatus
{
    CRIADO,
    VALIDADO,
    AGUARDANDO_VENCIMENTO,
    VENCIDO,
    EM_PROCESSAMENTO,
    PAGO,
    LIQUIDADO,
    CANCELADO,
    ERRO_PROCESSAMENTO
}