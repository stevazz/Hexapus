using Hexapus.Invoice.Domain.Aggregates;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Hexapus.Invoice.Application.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
    {
        private readonly IProductRepository productRepository;

        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Name, request.Note, request.SalePrice, request.Currency, request.Unit);
            product = await productRepository.CreateAsync(product);
            return product.Id;
        }
    }
}
