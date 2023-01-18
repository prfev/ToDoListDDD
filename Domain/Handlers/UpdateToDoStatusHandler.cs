using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ToDoListDDD.API.Commands.Requests;
using ToDoListDDD.Business.Commands.Responses;
using ToDoListDDD.Domain.Exceptions;
using ToDoListDDD.Domain.Repositories;

namespace ToDoListDDD.Domain.Handlers
{
    public class UpdateToDoStatusHandler : IRequestHandler<UpdateToDoStatusRequest,UpdateToDoStatusResponse>
    {
        IToDoRepository _repository;
        public UpdateToDoStatusHandler(IToDoRepository repository)
        {
            _repository = repository;
        }
        public Task<UpdateToDoStatusResponse> Handle(UpdateToDoStatusRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var updatedTodo = _repository.UpdateStatus(request.Id);
                var result = new UpdateToDoStatusResponse
                {
                    Id = updatedTodo.Id,
                    Name = updatedTodo.Name,
                    Description = updatedTodo.Description,
                    IsComplete = updatedTodo.IsComplete,
                    LastChanged = updatedTodo.LastChanged
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
