namespace sda_onsite_2_csharp_backend_teamwork.src.Entities;
public class OrderItem
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Order Order { get; set; }
    public Guid StockId { get; set; }
    public int Quantity { get; set; }
}
