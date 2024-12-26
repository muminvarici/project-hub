using ProjectHub.Domain.Events;
using Microsoft.Extensions.Logging;

namespace ProjectHub.Application.TodoItems.EventHandlers;

public class TodoItemCompletedEventHandler : INotificationHandler<TodoItemCompletedEvent>
{
    private readonly ILogger<TodoItemCompletedEventHandler> _logger;

    public TodoItemCompletedEventHandler(ILogger<TodoItemCompletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("ProjectHub Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
