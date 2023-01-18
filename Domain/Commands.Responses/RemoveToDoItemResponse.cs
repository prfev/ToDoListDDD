using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListDDD.Domain.Commands.Responses
{
    public class RemoveToDoItemResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }
}
