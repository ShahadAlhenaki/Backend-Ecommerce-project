using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

public class OrderItemRepository : IOrderItemRepository
{
    private DbSet<OrderItem> _orderItems;
    private DatabaseContext _databaseContext;

    public OrderItemRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
        _orderItems = databaseContext.OrderItem;
    }

    public IEnumerable<OrderItem> FindAll()
    {
        return _orderItems;
    }

    public IEnumerable<OrderItem> FindByStockId(Guid stockId)
    {
        return _orderItems.Where(item => item.StockId == stockId);
    }
    public OrderItem CreateOne(OrderItem orderItem)
    {
        _orderItems.Add(orderItem);
        _databaseContext.SaveChanges();
        return orderItem;
    }
}
