using Oink.Core.Domain.Contracts;

namespace Oink.Core.Domain.Extensions;

public static class DomainEventExtensions
{
    public static VersionedEventAttribute? GetEventMetadata(this IDomainEvent eventItem)
    {
        return eventItem.GetType()
            .GetCustomAttributes(false)
            .OfType<VersionedEventAttribute>()
            .FirstOrDefault();
    }
}