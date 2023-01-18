using ToDoListDDD.API.Queries.Requests;
using ToDoListDDD.Business.Handlers.Interfaces;
using ToDoListDDD.Business.Queries.Responses;
using ToDoListDDD.Domain.Exceptions;
using ToDoListDDD.Domain.Repositories;

namespace ToDoListDDD.Domain.Handlers
{
    public class GetToDoByIdHandler : IGetToDoByIdHandler
    {
        IToDoRepository _repository;
        public GetToDoByIdHandler(IToDoRepository repository)
        {
            _repository = repository;
        }
        public GetToDoByIdResponse Handle(GetToDoByIdRequest command)
        {
            try
            {
                var todoItem = _repository.GetItemById(command.Id);
                return new GetToDoByIdResponse
                {
                    Id = todoItem.Id,
                    Name = todoItem.Name,
                    IsComplete = todoItem.IsComplete,
                    Description = todoItem.Description,
                    LastChanged = todoItem.LastChanged
                };
            }
            catch
            {
                throw new ToDoIdIsNotValidException($"Id: {command.Id} doesn't exist in DataBase! Please try again.");
            }
        }
    }
}
