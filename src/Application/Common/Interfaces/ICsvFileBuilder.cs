using MyTodo.Application.TodoLists.Queries.ExportTodos;

namespace MyTodo.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
