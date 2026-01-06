using boleto.Application.Commands.NewFolder;
using FluentValidation;

namespace boleto.API.Helpers;

public static class ValidatorHelper
{
    public static IServiceCollection AddValidatorHelper(this IServiceCollection services)
    {
        services.AddScoped<IValidator<CreatePaymentBatchCommand>, CreatePaymentBatchCommandValidation>();
        return services;
    }
}
