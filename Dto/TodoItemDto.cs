
using ToDoMVCtutorial.Models;

namespace ToDoMVCtutorial.DTO
{
    public class TodoItemDto
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }

        public TodoItemDto? FromModel(TodoItem todoItem)
        {
            return todoItem == null ? null : new TodoItemDto
            { 
                Id = todoItem.Id,
                Name = todoItem.Name,
                IsComplete = todoItem.IsComplete,
            };
        }

    }
}
