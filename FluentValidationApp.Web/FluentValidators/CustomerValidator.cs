using FluentValidation;
using FluentValidationApp.Web.Models;
using System;

namespace FluentValidationApp.Web.FluentValidators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        private string NotEmptyMessage { get; } = "{PropertyName} can not be empty.";

        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(NotEmptyMessage);

            RuleFor(x => x.Email).NotEmpty().WithMessage(NotEmptyMessage)
                                 .EmailAddress().WithMessage("Please enter e-mail format.");

            RuleFor(x => x.Age).NotEmpty().WithMessage(NotEmptyMessage)
                               .InclusiveBetween(18, 60).WithMessage("Age must be between 18 and 60.");

            RuleFor(x => x.BirthDate).NotEmpty().WithMessage(NotEmptyMessage)
                .Must(x =>
                {
                    return DateTime.Now.AddYears(-18) >= x;
                }).WithMessage("Age must be greater or equal than 18.");


            RuleForEach(x => x.Addresses).SetValidator(new AddressValidator());

            RuleFor(x => x.Gender).IsInEnum().WithMessage("{PropertyName} must be for Female = 1,  Male = 2");
        }
    }
}
