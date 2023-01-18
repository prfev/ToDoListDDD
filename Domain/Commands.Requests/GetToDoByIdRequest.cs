using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListDDD.Domain.Commands.Requests
{
    public class GetToDoByIdRequest
    {
        public long Id { get; set; }
    }
}
