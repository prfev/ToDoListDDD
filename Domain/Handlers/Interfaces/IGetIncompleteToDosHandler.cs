using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListDDD.Domain.Commands.Responses;

namespace ToDoListDDD.Domain.Handlers
{
    public interface IGetIncompleteToDosHandler
    {
        GetIncompleteToDosResponse Handle();
    }
}
