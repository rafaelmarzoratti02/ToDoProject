using ToDo.Core.Entities;

namespace ToDo.Application.Models
{
    public class ToDoInputModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }

        public static ToDoItem ToEntity(ToDoInputModel input)
        {
            return new ToDoItem(
                input.Title,
                input.Description,
                input.DueDate
            );
        }
    }
}