namespace ToDoListDDD.Domain.Commands.Requests
{
    public class CreateToDoItemRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
