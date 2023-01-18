using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListDDD.Domain.Exceptions
{
    public class ToDoNameIsNotValidException : Exception
    {
        public string Status { get; set; }

        //public override string Message { get; }
    }
}
