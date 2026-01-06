using AutoMapper;
using boleto.Application.Commands.CreatePaymentBatch;
using boleto.Domain.Entity;

namespace boleto.Application.Profiles;

public class BankSlipPaymentBatchProfile : Profile
{
    public BankSlipPaymentBatchProfile()
    {
        CreateMap<CreatePaymentBatchCommand, BankSlipPaymentBatchEntity>();
    }
}
