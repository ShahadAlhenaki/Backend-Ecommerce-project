using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;


public interface IStockService
{
    public IEnumerable<Stock> FindAll();
    public IEnumerable<Stock> FindByProductId(Guid productId);
    public Stock? FindById(Guid id);
    public Stock CreateOne(StockCreateDto newProduct);
    public bool DeleteOneById(Guid id);
    public bool DeleteProductById(Guid productId);
    public Stock UpdateOne(Stock stock);
}
