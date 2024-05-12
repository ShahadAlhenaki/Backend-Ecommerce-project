using sda_onsite_2_csharp_backend_teamwork.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

public interface IOrderItemService
{
    public IEnumerable<OrderItem> FindAll();
    public IEnumerable<OrderItem> FindByStockId(Guid stockId);
    public OrderItem CreateOne(OrderItem orderItem);
}
