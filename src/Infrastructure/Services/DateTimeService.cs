using MyTodo.Application.Common.Interfaces;

namespace MyTodo.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
