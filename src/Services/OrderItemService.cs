using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork.src.Services;

public class OrderItemService : IOrderItemService
{
    private IOrderItemRepository _orderItemRepository;
    private IMapper _mapper;

    public OrderItemService(IOrderItemRepository orderItemRepository, IMapper mapper)
    {
        _orderItemRepository = orderItemRepository;
        _mapper = mapper;
    }
    public IEnumerable<OrderItem> FindAll()
    {
        return _orderItemRepository.FindAll();
    }
    public IEnumerable<OrderItem> FindByStockId(Guid stockId)
    {
        return _orderItemRepository.FindByStockId(stockId);
    }
    public OrderItem CreateOne(OrderItem orderItem)
    {
        return _orderItemRepository.CreateOne(orderItem);
    }
}
