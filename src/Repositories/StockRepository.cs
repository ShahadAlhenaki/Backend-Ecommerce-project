using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;
public class StockRepository : IStockRepository
{
    private DbSet<Stock> _stock;
    private DatabaseContext _databaseContext;
    public StockRepository(DatabaseContext databaseContext)
    {
        _stock = databaseContext.Stock;
        _databaseContext = databaseContext;
    }
    public Stock CreateOne(Stock newProduct)
    {
        _stock.Add(newProduct);
        _databaseContext.SaveChanges();
        return newProduct;
    }
    public IEnumerable<Stock> FindAll()
    {
        return _stock;
    }
    public IEnumerable<Stock> FindByProductId(Guid productId)
    {
        return _stock.Where(item => item.ProductId == productId);
    }
    public Stock? FindById(Guid id)
    {
        return _stock.FirstOrDefault(item => item.Id == id);
    }
    public bool DeleteOneById(Guid id)
    {
        Stock? stock = FindById(id);
        if (stock is null)
        {
            return false;
        }
        else
        {
            _stock.Remove(stock);
            _databaseContext.SaveChanges();
            return true;
        }
    }
    public bool DeleteProductById(Guid productId)
    {
        IEnumerable<Stock> unwantedProduct = FindByProductId(productId);
        if (unwantedProduct is null)
        {
            return false;
        }
        else
        {
            _stock.RemoveRange(unwantedProduct);
            _databaseContext.SaveChanges();

            return true;
        }
    }
    public Stock UpdateOne(Stock stock)
    {
        _stock.Update(stock);
        _databaseContext.SaveChanges();

        return stock;
    }
}
