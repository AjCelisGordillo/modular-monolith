using Evently.Common.Presentation.Endpoints;
using Evently.Modules.Ticketing.Application.Carts;
using Evently.Modules.Ticketing.Presentation.Customers;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;

namespace Evently.Modules.Ticketing.Infrastructure;

public static class TicketingModule
{
    public static IServiceCollection AddTicketingModule(
    this IServiceCollection services)
    {
        services.AddInfrastructure();

        services.AddEndpoints(Presentation.AssemblyReference.Assembly);

        return services;
    }

    public static void ConfigureConsumers(IRegistrationConfigurator registrationConfigurator)
    {
        registrationConfigurator.AddConsumer<UserRegisteredIntegrationEventConsumer>();
    }

    private static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<CartService>();
    }
}
