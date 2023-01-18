using ToDoListDDD.Domain.Exceptions;
using ToDoListDDD.Domain.Specifications;

namespace ToDoListDDD.Domain.Services
{
    public class ToDoValidationService : IToDoValidationService
    {
        private readonly ToDoNameValidationSpecification _nameValidator = new ToDoNameValidationSpecification();
        
        public void NameIsValid(string name)
        {
            
            _nameValidator.Execute(name);
            if (!_nameValidator.IsValid)
            {
                throw new ToDoNameIsNotValidException("Name is not valid! Try again.");
            }

        }
    }
}
