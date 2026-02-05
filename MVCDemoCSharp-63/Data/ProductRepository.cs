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
        return _connection.Query<Product>("SELECT * FROM products");
    }

    public Product? GetProduct(int id)
    {
        return _connection.QuerySingle<Product>("SELECT * FROM PRODUCTS WHERE PRODUCTID = @id", new { id = id });
    }

    public void UpdateProduct(Product product)
    {
        _connection.Execute(
            "UPDATE products SET Name = @name, Price = @price WHERE ProductID = @id",
        new {product.Name, product.Price, id = product.ProductID });
    }

    public void InsertProduct(Product productToInsert)
    {
        _connection.Execute(
            "INSERT INTO products (NAME, PRICE, CATEGORYID) VALUES (@name, @price, @categoryID);", 
         new { name = productToInsert.Name, price = productToInsert.Price, CategoryID = productToInsert.CategoryID });
    }

    public IEnumerable<Category> GetCategories()
    {
        return _connection.Query<Category>("SELECT * FROM categories;");
    }

    public Product AssignCategory()
    {
        var categoryList = GetCategories();
        var product = new Product();
        product.Categories = categoryList;
        return product;
    }

    public void DeleteProduct(Product product)
    {
        _connection.Execute("DELETE FROM REVIEWS WHERE ProductID = @id;", new { id = product.ProductID });
        _connection.Execute("DELETE FROM Sales WHERE ProductID = @id;", new { id = product.ProductID });
        _connection.Execute("DELETE FROM Products WHERE ProductID = @id;", new { id = product.ProductID });
    }
}