using FluentValidation.Results;
using MediatR;

namespace NSE.Core.Messages
{
    public abstract class Command : Message, IRequest<ValidationResult>
    {
        public DateTime TimesTamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            TimesTamp = DateTime.Now;
        }
        public virtual bool EhValido()
        {
            throw new NotImplementedException();
        }
    }

}
