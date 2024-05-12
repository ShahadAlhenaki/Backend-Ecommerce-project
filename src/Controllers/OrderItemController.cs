using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers;


public class OrderItemController : BaseController
{
    private IOrderItemService _orderItemService;
    public OrderItemController(IOrderItemService orderItemService)
    {
        _orderItemService = orderItemService;
    }

    [HttpGet]
    [Authorize(Roles = "Admin")]

    public IEnumerable<OrderItem> FindAll()
    {
        return _orderItemService.FindAll();
    }

    [HttpGet("stock/{stockId}")]
    public ActionResult<IEnumerable<OrderItem>> FindByStockId(Guid stockId)
    {
        var orderQuantity = _orderItemService.FindByStockId(stockId);

        if (orderQuantity is null)
        {
            return NotFound();
        }
        return Ok(orderQuantity);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<OrderItem> CreateOne(OrderItem newOrder)
    {
        if (newOrder is not null)
        {
            _orderItemService.CreateOne(newOrder);
            return CreatedAtAction(nameof(CreateOne), newOrder);
        }
        return BadRequest();
    }
}
