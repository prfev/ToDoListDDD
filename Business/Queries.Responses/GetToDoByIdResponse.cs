using System;

namespace ToDoListDDD.Business.Queries.Responses
{
    public class GetToDoByIdResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string Description { get; set; }
        public DateTime LastChanged { get; set; }
    }
}
