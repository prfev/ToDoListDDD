using MediatR;
using ToDoListDDD.Business.Commands.Responses;

namespace ToDoListDDD.API.Commands.Requests
{
    public class RemoveToDoItemRequest : IRequest<RemoveToDoItemResponse>
    {
        public long Id { get; set; }
    }
}
