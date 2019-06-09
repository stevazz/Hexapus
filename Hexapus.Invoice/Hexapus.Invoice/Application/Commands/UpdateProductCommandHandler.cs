using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Hexapus.Invoice.Application.Commands
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        public Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
