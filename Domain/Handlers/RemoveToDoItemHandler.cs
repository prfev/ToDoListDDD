using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListDDD.Domain.Commands.Requests;
using ToDoListDDD.Domain.Commands.Responses;
using ToDoListDDD.Domain.Exceptions;
using ToDoListDDD.Infrastructure;

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
