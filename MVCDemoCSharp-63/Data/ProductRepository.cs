using System.Data;
using Dapper;
using MVCDemoCSharp_63.Models;

namespace MVCDemoCSharp_63.Data;

public class ProductRepository : IProductRepository
{
    private readonly IDbConnection _connection;

    public ProductRepository(IDbConnection connection)
    {
        _connection = connection;
    }
        
    public IEnumerable<Product> GetAllProducts()
    {
        return _connection.Query<Product>("SELECT * FROM products;");
    }
}