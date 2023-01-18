using System.Collections.Generic;
using ToDoListDDD.API.Commands.Requests;
using ToDoListDDD.Business.Commands.Responses;
using ToDoListDDD.Business.Handlers.Interfaces;
using ToDoListDDD.Domain.Exceptions;
using ToDoListDDD.Domain.Repositories;

namespace ToDoListDDD.Domain.Handlers
{
    public class RemoveToDoItemHandler : IRemoveToDoItemHandler
    {
        IToDoRepository _repository;
        public RemoveToDoItemHandler(IToDoRepository repository)
        {
            _repository = repository;
        }
        public RemoveToDoItemResponse Handle(RemoveToDoItemRequest command)
        {
            try
            {
                _repository.Remove(command.Id);
                return new RemoveToDoItemResponse
                {
                    Status = "Success!!",
                    Message = "Item Deleted!!"
                };
            }
            catch
            {
                throw new ToDoIdIsNotValidException($"Id: {command.Id} doesn't exist in DataBase! Please try again.");
            }
        }
    }
}
