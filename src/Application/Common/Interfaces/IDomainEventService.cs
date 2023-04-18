using MyTodo.Domain.Common;

namespace MyTodo.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
