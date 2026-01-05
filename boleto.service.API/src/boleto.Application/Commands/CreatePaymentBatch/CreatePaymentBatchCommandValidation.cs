using FluentValidation;

namespace boleto.Application.Commands.NewFolder;

public class CreatePaymentBatchCommandValidation : AbstractValidator<CreatePaymentBatchCommand>
{
    public CreatePaymentBatchCommandValidation()
    {
        RuleFor(x => x.RequesterId)
            .NotEmpty().WithMessage("RequesterId is required.");
        RuleFor(x => x.PaymentTitles)
            .NotEmpty().WithMessage("At least one PaymentTitle is required.");
        RuleForEach(x => x.PaymentTitles).ChildRules(paymentTitle =>
        {
            paymentTitle.RuleFor(pt => pt.PaymentId)
                .NotEqual(Guid.Empty).WithMessage("PaymentId must be a valid GUID.");
            paymentTitle.RuleFor(pt => pt.PaymentCode)
                .NotEmpty().WithMessage("PaymentCode is required.");
            paymentTitle.RuleFor(pt => pt.Amount)
                .GreaterThan(0).WithMessage("Amount must be greater than zero.");
        });
    }
}
