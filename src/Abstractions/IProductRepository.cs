using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

public interface IProductRepository
{
  //public IEnumerable<Product> FindAll(int limit, int offset);
  public IEnumerable<ProductWithStock> FindAll(string? searchBy);
  public Product? FindeOne(Guid Id);
  public Product CreateOne(Product product);
  public bool DeleteById(Guid id);
  public Product UpdateOne(Product product);

}
