using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListDDD.Domain.Entities;

namespace ToDoListDDD.Domain.Commands.Responses
{
    public class GetAllToDoItemsResponse
    {
        public IEnumerable<ToDoItem> ToDoItems { get; set; }
    }
}
