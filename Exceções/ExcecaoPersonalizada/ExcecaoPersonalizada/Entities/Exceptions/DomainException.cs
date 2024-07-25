using System;

namespace ExcecaoPersonalizada.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        //Herdar a ApplicationException
        //Recebe uma mensagem e passa ela para a SuperClasse
        public DomainException(string message) : base(message)
        {
        }  
    }
}
