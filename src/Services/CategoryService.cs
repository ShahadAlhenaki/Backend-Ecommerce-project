using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services;

public class CategoryService : ICategoryService
{
    private ICategoryRepository _categoryRepository;
    private IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public Category CreateOne(CategoryCreateDto category)
    {
        var newCategory = _mapper.Map<Category>(category);
        var createdCategory = _categoryRepository.CreateOne(newCategory);
        return createdCategory;
    }

    public IEnumerable<Category> FindAll()
    {
        return _categoryRepository.FindAll();
    }
}