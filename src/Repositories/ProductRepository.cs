using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class ProductRepository : IProductRepository
{
    private DbSet<Product> _products;
    private DatabaseContext _databaseContext;
    public ProductRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
        _products = _databaseContext.Product;
    }
    // public IEnumerable<Product> FindAll(int limit, int offset)
    // {
    //     if (limit == 0 && offset == 0)
    //     {
    //         return _products;
    //     }
    //     return _products.Skip(offset).Take(limit);
    // }

    public IEnumerable<Product> FindAll(string? searchBy)
        {
            return _products;
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

    public bool DeleteById(Guid id){
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
