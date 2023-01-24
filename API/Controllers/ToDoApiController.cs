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
        private readonly IMediator _mediator;
        public ToDoApiController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        [Route("")]
        public IActionResult CreateToDo([FromBody]CreateToDoItemRequest command)
        {
            try
            {
                var response = _mediator.Send(command);
                return Ok(response.Result);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete]
        [Route("deleteItem")]
        public IActionResult DeleteToDo([FromBody]RemoveToDoItemRequest command)
        {
            try
            {
                var response = _mediator.Send(command);
                return Ok(response.Result);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        [Route("UpdateItemStatus")]
        public IActionResult UpdateToDoStatus([FromBody]UpdateToDoStatusRequest command)
        {
            try
            {
                var response = _mediator.Send(command);
                return Ok(response.Result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        [Route("UpdateItemDescription")]
        public IActionResult UpdateToDoDescription([FromBody] UpdateToDoDescriptionRequest command)
        {
            try
            {
                var response = _mediator.Send(command);
                return Ok(response.Result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        [Route("")]
        public IActionResult GetAllToDos([FromForm] GetAllToDosRequest query)
        {
            var response = _mediator.Send(query);
            return Ok(response.Result.ToDoItems);
        }
        [HttpGet]
        [Route("Search")]
        public IActionResult GetToDoById([FromBody] GetToDoByIdRequest query)
        {
            try
            {
                var response = _mediator.Send(query);
                return Ok(response.Result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        [Route("incomplete")]
        public IActionResult GetIncompleteToDos([FromForm] GetIncompleteToDosRequest query)
        {
            var response = _mediator.Send(query);
            return Ok(response.Result.IncompleteItems);
        }
    }
}
