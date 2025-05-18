using System;

namespace ToDo.Core.Entities
{
    public class ToDoItem : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; } 
        public DateTime? DueDate { get; set; }

        public ToDoItem(string title, string description, DateTime? dueDate = null) :base()
        {
            Title = title;
            Description = description;
            IsCompleted = false;
            DueDate = dueDate;
        }
    }
}