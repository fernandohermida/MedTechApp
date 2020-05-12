using MedTechApp.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace MedTechApp.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
