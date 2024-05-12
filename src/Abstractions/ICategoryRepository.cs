using sda_onsite_2_csharp_backend_teamwork.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

public interface ICategoryRepository
{
    public IEnumerable<Category> FindAll();
    public Category CreateOne(Category category);
}
