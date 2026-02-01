using Microsoft.AspNetCore.Mvc;
using MVCDemoCSharp_63.Data;

namespace MVCDemoCSharp_63.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository _repo;

    public ProductController(IProductRepository repo)
    {
        _repo = repo;
    }
    // GET
    public IActionResult Index()
    {
        var products = _repo.GetAllProducts();
        return View(products);
    }
}