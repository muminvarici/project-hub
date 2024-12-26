using ProjectHub.Domain.Events;
using Microsoft.Extensions.Logging;

namespace ProjectHub.Application.TodoItems.EventHandlers;

public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("ProjectHub Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
