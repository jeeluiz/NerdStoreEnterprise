
using FluentValidation;
using FluentValidation.Results;
using NSE.Core.Messages;

namespace NSE.Clientes.API.Application.Commands
{
    public class RegistrarClienteCommand : Command
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }

        public RegistrarClienteCommand(Guid id, string nome, string email, string cpf)
        {
            AggregateId = id;
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
        }
        public override bool EhValido()
        {
            ValidationResult = new RegistrarClienteValidation().Validate(instance: this);
            return ValidationResult.IsValid;
        }
    }


    public class RegistrarClienteValidation : AbstractValidator<RegistrarClienteCommand>
    {
        public RegistrarClienteValidation()
        {
            RuleFor(expression:c => c.Id)
                .NotEmpty()
                .WithMessage("Id do Cliente invalido");
          
            RuleFor(expression: c => c.Nome)
               .NotEmpty()
               .WithMessage("Nome do Cliente invalido");
           
            RuleFor(expression: c => c.Cpf)
               .NotEmpty()
               .WithMessage("Cpf do Cliente invalido");
            
            RuleFor(expression: c => c.Email)
               .NotEmpty()
               .WithMessage("Email do Cliente invalido");
        }

        protected static bool TerCpfValido(string cpf)
        {
            return Core.DomainObjects.Cpf.Validar(cpf);
        }

        protected static bool TerEmailValido(string email)
        {
            return Core.DomainObjects.Email.Validar(email);
        }

    }
}
