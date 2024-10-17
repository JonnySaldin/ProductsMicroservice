using Microsoft.AspNetCore.Mvc;
using ProductsMicroservice.Models;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    // In-memory store of products (replace with DB later)
    private static List<Product> _products = new List<Product>
    {
        new Product { Id = 1, Name = "Laptop", Price = 999.99M },
        new Product { Id = 2, Name = "Smartphone", Price = 499.99M }
    };

    // GET api/products
    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetProducts()
    {
        return Ok(_products);
    }

    // GET api/products/{id}
    [HttpGet("{id}")]
    public ActionResult<Product> GetProduct(int id)
    {
        var product = _products.Find(p => p.Id == id);
        if (product == null) return NotFound();
        return Ok(product);
    }
}