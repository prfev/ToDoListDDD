namespace ToDoListDDD.Domain.Specifications
{
    public class ToDoNameValidationSpecification
    {
    
        public bool IsValid = true;
        public void Execute(string name)
        {
            ToDoNameIsNotEmpty(name);
            ToDoNameIsNotNull(name);
        }
        public void ToDoNameIsNotEmpty(string name)
        {
            if (name != "" & name != " ")
            {
                IsValid ^= true;
            }
            else
            {
                IsValid ^= false;
            }
        }
        public void ToDoNameIsNotNull(string name)
        {
            if (name != null)
            {
                IsValid ^= true;
            }
            else
            {
                IsValid ^= false;
            }
        }

    }
}
