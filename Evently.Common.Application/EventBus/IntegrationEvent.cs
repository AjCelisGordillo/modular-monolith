namespace Evently.Common.Application.EventBus;

public abstract class IntegrationEvent : IIntegrationEvent
{
    protected IntegrationEvent(Guid id, DateTime ocurredOnUtc)
    {
        Id = id;
        OcurredOnUtc = ocurredOnUtc;
    }

    public Guid Id { get; init; }
    public DateTime OcurredOnUtc { get; init; }
}
