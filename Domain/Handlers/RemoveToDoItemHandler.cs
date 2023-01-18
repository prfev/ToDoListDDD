using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListDDD.Domain.Commands.Requests;
using ToDoListDDD.Domain.Commands.Responses;
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
            _repository.Remove(command.id);
            return new RemoveToDoItemResponse
            {
                Status = "Success!!",
                Message = "Item Deleted!!"
            };
        }
    }
}
