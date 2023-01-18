using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListDDD.Domain.Commands.Requests;
using ToDoListDDD.Domain.Handlers;

namespace ToDoListDDD.Controllers
{
    [ApiController]
    [Route("v1/todoItems")]
    public class ToDoApiController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public IActionResult CreateToDo([FromServices]ICreateToDoItemHandler handler, [FromBody]CreateToDoItemRequest command)
        {
            try
            {
                var response = handler.Handle(command);
                return Ok(response);
            }
            catch(Exception e)
            {
                return Ok(e.Message);
            }
        }
        [HttpDelete]
        [Route("deleteItem")]
        public IActionResult DeleteToDo([FromServices]IRemoveToDoItemHandler handler, [FromBody]RemoveToDoItemRequest command)
        {
            var response = handler.Handle(command);
            return Ok(response);
        }
        [HttpPut]
        [Route("UpdateItem")]
        public IActionResult UpdateToDo([FromServices]IUpdateToDoStatusHandler handler, [FromBody]UpdateToDoStatusRequest command)
        {
            var response = handler.Handle(command);
            return Ok(response);
        }
        [HttpGet]
        [Route("")]
        public IActionResult GetAllToDos([FromServices] IGetAllToDoItemsHandler handler)
        {
            var response = handler.Handle();
            return Ok(response);
        }
        [HttpGet]
        [Route("Search")]
        public IActionResult GetToDoById([FromServices] IGetToDoByIdHandler handler, [FromBody] GetToDoByIdRequest command)
        {
            var response = handler.Handle(command);
            return Ok(response);
        }
        [HttpGet]
        [Route("incomplete")]
        public IActionResult GetIncompleteToDos([FromServices]IGetIncompleteToDosHandler handler)
        {
            var response = handler.Handle();
            return Ok(response);
        }
    }
}
