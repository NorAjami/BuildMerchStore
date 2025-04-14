using MerchStore.Domain.Entities;

namespace MerchStore.Domain.Interfaces;

public interface IProductRepository : IRepository<Product, Guid>
{
    // Lägg till metoder som GetByNameAsync, GetByCategory osv. senare
}
