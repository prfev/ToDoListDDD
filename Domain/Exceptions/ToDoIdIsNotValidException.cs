using System;

namespace ToDoListDDD.Domain.Exceptions
{
    public class ToDoIdIsNotValidException : Exception
    {
        public ToDoIdIsNotValidException() : base() { }
        public ToDoIdIsNotValidException(string message) : base(message) { }
    }
}
