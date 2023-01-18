using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListDDD.Domain.Commands.Requests;
using ToDoListDDD.Domain.Commands.Responses;

namespace ToDoListDDD.Domain.Handlers
{
    public interface IUpdateToDoStatusHandler
    {
        UpdateToDoStatusResponse Handle(UpdateToDoStatusRequest command);
    }
}
