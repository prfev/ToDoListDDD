using ToDoListDDD.API.Commands.Requests;
using ToDoListDDD.Business.Commands.Responses;
using ToDoListDDD.Business.Handlers.Interfaces;
using ToDoListDDD.Domain.Exceptions;
using ToDoListDDD.Domain.Repositories;

namespace ToDoListDDD.Domain.Handlers
{
    public class UpdateToDoStatusHandler : IUpdateToDoStatusHandler
    {
        IToDoRepository _repository;
        public UpdateToDoStatusHandler(IToDoRepository repository)
        {
            _repository = repository;
        }
        public UpdateToDoStatusResponse Handle(UpdateToDoStatusRequest command)
        {
            try
            {
                var updatedTodo = _repository.UpdateStatus(command.Id);
                return new UpdateToDoStatusResponse
                {
                    Id = updatedTodo.Id,
                    Name = updatedTodo.Name,
                    Description = updatedTodo.Description,
                    IsComplete = updatedTodo.IsComplete,
                    CreatedAt = updatedTodo.CreatedAt
                };
            }
            catch
            {
                throw new ToDoIdIsNotValidException($"Id: {command.Id} doesn't exist in DataBase! Please try again.");
            }
        }
    }
}
