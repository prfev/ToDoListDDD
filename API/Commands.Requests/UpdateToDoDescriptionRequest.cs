using MediatR;
using ToDoListDDD.Business.Commands.Responses;

namespace ToDoListDDD.API.Commands.Requests
{
    public class UpdateToDoDescriptionRequest : IRequest<UpdateToDoDescriptionResponse>
    {
        public long Id { get; set; }
        public string Description { get; set; }
    }
}
