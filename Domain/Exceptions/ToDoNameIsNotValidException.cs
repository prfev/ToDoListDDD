using System;

namespace ToDoListDDD.Domain.Exceptions
{
    public class ToDoNameIsNotValidException : Exception
    {
        public ToDoNameIsNotValidException() : base() { }
        public ToDoNameIsNotValidException(string message) : base(message) { }
    }
}
