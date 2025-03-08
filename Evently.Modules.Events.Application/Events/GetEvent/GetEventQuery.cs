using Evently.Common.Application.Messaging;
using static Evently.Modules.Events.Application.Events.GetEvent.GetEvent;

namespace Evently.Modules.Events.Application.Events.GetEvent;

public sealed record GetEventQuery(Guid EventId) : IQuery<EventResponse>;
