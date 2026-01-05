using boleto.Application.Commands.NewFolder;
using FluentValidation;

namespace boleto.API.Halpers;

public static class ValidatorHelper
{
    public static IServiceCollection AddValidatorHelper(this IServiceCollection services)
    {
        services.AddScoped<IValidator<CreatePaymentBatchCommand>, CreatePaymentBatchCommandValidation>();
        return services;
    }
}
