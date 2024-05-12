namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

public interface IProductRepository
{
  public IEnumerable<Product> FindAll(int limit, int offset);

  public Product? FindeOne(Guid Id);
  public Product CreateOne(Product product);
}
