using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hexapus.Invoice.Domain.Aggregates
{
    public interface IProductRepository
    {
        Task<Product> CreateAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task DeleteByIdAsync(Guid id);
        Task<Product> FindByIdAsync(Guid id);
    }
}
