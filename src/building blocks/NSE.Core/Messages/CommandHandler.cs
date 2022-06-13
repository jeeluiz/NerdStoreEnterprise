﻿using FluentValidation.Results;

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

    }
}
