using System;

namespace ToDoListDDD.Business.Commands.Responses
{
    public class CreateToDoItemResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
