using Microsoft.AspNetCore.Mvc;
using OrdersMicroservice.Models;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private static List<Order> _orders = new List<Order>
    {
        new Order { Id = 1, OrderDate = DateTime.Now, CustomerName = "John Doe", ProductIds = new List<int> { 1 } },
        new Order { Id = 2, OrderDate = DateTime.Now, CustomerName = "Jane Doe", ProductIds = new List<int> { 2 } }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Order>> GetOrders()
    {
        return Ok(_orders);
    }

    [HttpGet("{id}")]
    public ActionResult<Order> GetOrder(int id)
    {
        var order = _orders.Find(o => o.Id == id);
        if (order == null) return NotFound();
        return Ok(order);
    }
}