using FluentValidation;
using Hexapus.Invoice.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hexapus.Invoice.Application.Validations
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.Currency).NotNull().IsInEnum();
            RuleFor(x => x.Unit).NotNull().IsInEnum();
            RuleFor(x => x.Name).NotEmpty().MaximumLength(200);
            RuleFor(x => x.Note);
            RuleFor(x => x.SalePrice).NotNull().GreaterThan(0);
        }
    }
}
