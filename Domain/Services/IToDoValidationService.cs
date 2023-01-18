using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListDDD.Domain.Services
{
    public interface IToDoValidationService
    {
        public void NameIsValid(string name);
    }
}
