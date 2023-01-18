using System;

namespace ToDoListDDD.Business.Commands.Responses
{
    public class UpdateToDoStatusResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string Description { get; set; }
        public DateTime LastChanged { get; set; } = DateTime.Now;
    }
}
