using FluentValidation.Results;
using NSE.Core.Data;

namespace NSE.Core.Messages
{
    public abstract class CommandHandler
    {
        protected ValidationResult ValidationResult;

        protected CommandHandler( )
        {
            ValidationResult = new ValidationResult();
        }
       
        protected void AdicionarErro(string message)
        {
            ValidationResult.Errors.Add(new ValidationFailure(propertyName:string.Empty,errorMessage:message));
        }

        protected async Task<ValidationResult> PersistirDados(IUnitOfWork uow)
        {
            if (!await uow.Commit()) AdicionarErro(message: "Houve um erro ao persistir os dados");
            return ValidationResult; 
        }

    }
}
