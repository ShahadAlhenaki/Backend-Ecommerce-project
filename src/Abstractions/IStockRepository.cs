using sda_onsite_2_csharp_backend_teamwork.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

public interface IStockRepository
{
    public IEnumerable<Stock> FindAll();
    public IEnumerable<Stock> FindByProductId(Guid productId);
    public Stock? FindById(Guid id);
    public Stock CreateOne(Stock newProduct);
    public bool DeleteOneById(Guid id);
    public bool DeleteProductById(Guid productId);
    public Stock UpdateOne(Stock stock);
}
