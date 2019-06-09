using FluentValidation;
using Hexapus.Invoice.Application.Commands;

namespace Hexapus.Invoice.Application.Validations
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Currency).NotEmpty().IsInEnum();
            RuleFor(x => x.Unit).NotEmpty().IsInEnum();
            RuleFor(x => x.Name).NotEmpty().MaximumLength(200);
            RuleFor(x => x.Note).NotEmpty();
            RuleFor(x => x.SalePrice).NotEmpty().GreaterThan(0);
        }
    }
}
