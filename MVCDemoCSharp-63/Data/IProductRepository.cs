using MVCDemoCSharp_63.Models;

namespace MVCDemoCSharp_63.Data;

public interface IProductRepository
{
    public IEnumerable<Product> GetAllProducts();
}