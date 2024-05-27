using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class ProductRepository : IProductRepository
{
    private DbSet<Product> _products;
    private DbSet<Stock> _stocks;

    private DatabaseContext _databaseContext;
    public ProductRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
        _products = _databaseContext.Product;
        _stocks = databaseContext.Stock;
    }
    // public IEnumerable<Product> FindAll(int limit, int offset)
    // {
    //     if (limit == 0 && offset == 0)
    //     {
    //         return _products;
    //     }
    //     return _products.Skip(offset).Take(limit);
    // }

    public IEnumerable<ProductWithStock> FindAll(string? searchBy)
    {
        var productWithStock = from product in _products
                               join stock in _stocks
                               on product.Id equals stock.ProductId
                               into productStocks
                               from stock in productStocks.DefaultIfEmpty()
                               select new ProductWithStock
                               {
                                   Id = product.Id,
                                   CategoryId = product.CategoryId,
                                   StockId = stock != null ? stock.Id : null,
                                   Color = stock != null ? stock.Color : null,
                                   Price = stock != null ? stock.Price : null,
                                   Description = product.Description,
                                   Image = product.Image,
                                   Name = product.Name,
                                   Quantity = stock != null ? stock.StockQuantity : (int?)null
                               };
        return productWithStock;
    }

    public Product? FindeOne(Guid Id)
    {
        Product? product = _products.FirstOrDefault(product => product.Id == Id);
        if (product != null)
        {
            return product;
        }
        return null;
    }
    public Product CreateOne(Product product)
    {
        _products.Add(product);
        _databaseContext.SaveChanges();
        return product;
    }

    public bool DeleteById(Guid id)
    {
        Product? product = FindeOne(id);
        if (product is null)
        {
            return false;
        }
        else
        {
            _products.Remove(product);
            _databaseContext.SaveChanges();
            return true;
        }
    }

    public Product UpdateOne(Product UpdateProduct)
    {
        _databaseContext.Product.Update(UpdateProduct);
        _databaseContext.SaveChanges();

        return UpdateProduct;
    }

}
