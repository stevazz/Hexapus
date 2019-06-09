using FluentValidation;
using Hexapus.Invoice.Application.Commands;
using Hexapus.Invoice.Application.Validations;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Hexapus.Invoice.Infrastructure.DependencyInjection
{
    public static class MediatorExtensions
    {
        public static IServiceCollection AddMediator(this IServiceCollection services)
        {
            services.AddScoped<ServiceFactory>(p => p.GetService);

            services.Scan(scan => scan
                .FromAssembliesOf(typeof(IMediator), typeof(CreateProductCommand))
                .AddClasses()
                .AsImplementedInterfaces());

            services.Scan(scan => scan
               .FromAssembliesOf(typeof(CreateProductCommandValidator))
               .AddClasses(a => a.AssignableTo(typeof(IValidator<>)))
               .AsImplementedInterfaces());

            return services;
        }
    }
}
