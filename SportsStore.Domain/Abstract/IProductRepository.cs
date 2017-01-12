using System.Linq;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract
{
    interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
