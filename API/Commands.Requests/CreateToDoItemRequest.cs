using MediatR;
using ToDoListDDD.Business.Commands.Responses;

namespace ToDoListDDD.API.Commands.Requests
{
    public class CreateToDoItemRequest : IRequest<CreateToDoItemResponse>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
