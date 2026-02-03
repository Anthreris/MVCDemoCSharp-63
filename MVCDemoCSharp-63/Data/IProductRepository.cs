using MVCDemoCSharp_63.Models;

namespace MVCDemoCSharp_63.Data;

public interface IProductRepository
{
    public IEnumerable<Product> GetAllProducts();
    Product GetProduct(int id);
    void UpdateProduct(Product product);
}