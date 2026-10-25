using Microsoft.Extensions.DependencyInjection;

namespace FiyatGor.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<GetProductByBarcode>();

        return services;
    }
}
