using System;

namespace ToDoListDDD.Domain.Entities
{
    public class ToDoItem
    {
        public ToDoItem(string name, string description)
        {
            Id = new long();
            Name = name;
            IsComplete = false;
            Description = description;
            CreatedAt = DateTime.Now;
        }
        public long Id {get; set;}
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}