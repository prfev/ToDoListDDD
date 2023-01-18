using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListDDD.Domain.Commands.Requests
{
    public class RemoveToDoItemRequest
    {
        public long Id { get; set; }
    }
}
