using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private DbSet<Category> _categorys;
    private DatabaseContext _databaseContext;

    public CategoryRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
        _categorys = databaseContext.Category;
    }

    public IEnumerable<Category> FindAll()
    {
        return _categorys;
    }

    public Category CreateOne(Category category)
    {
        _categorys.Add(category);
        _databaseContext.SaveChanges();
        return category;
    }
}
