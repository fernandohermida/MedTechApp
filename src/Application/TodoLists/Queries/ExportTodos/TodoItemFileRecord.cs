using MedTechApp.Application.Common.Mappings;
using MedTechApp.Domain.Entities;

namespace MedTechApp.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
