using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using ToDoListDDD.API.Commands.Requests;
using ToDoListDDD.API.Queries.Requests;

namespace ToDoListDDD.API.Controllers
{
    [ApiController]
    [Route("v1/todoItems")]
    public class ToDoApiController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public IActionResult CreateToDo([FromServices]IMediator mediator, [FromBody]CreateToDoItemRequest command)
        {
            try
            {
                var response = mediator.Send(command);
                return Ok(response.Result);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete]
        [Route("deleteItem")]
        public IActionResult DeleteToDo([FromServices]IMediator mediator, [FromBody]RemoveToDoItemRequest command)
        {
            try
            {
                var response = mediator.Send(command);
                return Ok(response.Result);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        [Route("UpdateItem")]
        public IActionResult UpdateToDo([FromServices]IMediator mediator, [FromBody]UpdateToDoStatusRequest command)
        {
            try
            {
                var response = mediator.Send(command);
                return Ok(response.Result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        [Route("")]
        public IActionResult GetAllToDos([FromServices] IMediator mediator,[FromForm] GetAllToDosRequest query)
        {
            var response = mediator.Send(query);
            return Ok(response.Result.ToDoItems);
        }
        [HttpGet]
        [Route("Search")]
        public IActionResult GetToDoById([FromServices] IMediator mediator, [FromBody] GetToDoByIdRequest query)
        {
            try
            {
                var response = mediator.Send(query);
                return Ok(response.Result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        [Route("incomplete")]
        public IActionResult GetIncompleteToDos([FromServices] IMediator mediator,[FromForm] GetIncompleteToDosRequest query)
        {
            var response = mediator.Send(query);
            return Ok(response.Result.IncompleteItems);
        }
    }
}
