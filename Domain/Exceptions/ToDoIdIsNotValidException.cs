using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListDDD.Domain.Exceptions
{
    public class ToDoIdIsNotValidException : Exception
    {
        public ToDoIdIsNotValidException() : base() { }
        public ToDoIdIsNotValidException(string message) : base(message) { }
    }
}
