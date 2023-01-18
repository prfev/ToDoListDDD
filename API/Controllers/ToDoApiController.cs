using Microsoft.AspNetCore.Mvc;
using System;
using ToDoListDDD.API.Commands.Requests;
using ToDoListDDD.API.Queries.Requests;
using ToDoListDDD.Business.Handlers.Interfaces;

namespace ToDoListDDD.API.Controllers
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
                return BadRequest(e.Message);
            }
        }
        [HttpDelete]
        [Route("deleteItem")]
        public IActionResult DeleteToDo([FromServices]IRemoveToDoItemHandler handler, [FromBody]RemoveToDoItemRequest command)
        {
            try
            {
                var response = handler.Handle(command);
                return Ok(response);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        [Route("UpdateItem")]
        public IActionResult UpdateToDo([FromServices]IUpdateToDoStatusHandler handler, [FromBody]UpdateToDoStatusRequest command)
        {
            try
            {
                var response = handler.Handle(command);
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
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
            try
            {
                var response = handler.Handle(command);
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
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
