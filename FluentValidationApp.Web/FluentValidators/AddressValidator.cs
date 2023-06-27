using FluentValidation;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.FluentValidators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        private string NotEmptyMessage { get; } = "{PropertyName} alanı boş olamaz.";
        public AddressValidator()
        {
            RuleFor(x => x.Content).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x => x.Province).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x => x.PostalCode).NotEmpty().WithMessage(NotEmptyMessage)
                .MaximumLength(5).WithMessage("{PropertyName} alanı en fazla {MaxLength} karakterde olmalıdır.");
        }
    }
}
