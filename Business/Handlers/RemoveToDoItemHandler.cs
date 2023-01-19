using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ToDoListDDD.API.Commands.Requests;
using ToDoListDDD.Business.Commands.Responses;
using ToDoListDDD.Domain.Exceptions;
using ToDoListDDD.Domain.Repositories;

namespace ToDoListDDD.Business.Handlers
{
    public class RemoveToDoItemHandler : IRequestHandler<RemoveToDoItemRequest,RemoveToDoItemResponse>
    {
        IToDoRepository _repository;
        public RemoveToDoItemHandler(IToDoRepository repository)
        {
            _repository = repository;
        }
        public Task<RemoveToDoItemResponse> Handle(RemoveToDoItemRequest request, CancellationToken cancellationToken)
        {
            try
            {
                _repository.Remove(request.Id);
                var result = new RemoveToDoItemResponse
                {
                    Status = "Success!!",
                    Message = "Item Deleted!!"
                };
                return Task.FromResult(result);
            }
            catch
            {
                throw new ToDoIdIsNotValidException($"Id: {request.Id} doesn't exist in DataBase! Please try again.");
            }
        }
    }
}
