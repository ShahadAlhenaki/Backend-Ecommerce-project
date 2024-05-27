using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

public interface IProductService
{
    //public IEnumerable<ProductDTO> FindAll(int limit, int offset);
    public IEnumerable<ProductWithStock> FindAll(string? searchBy);

    public ProductDTO? FindeOne(Guid Id);
    public ProductDTO CreateOne(ProductCreateDTO product);

    public bool DeleteById(Guid id);

    public   ProductReadDTO  UpdateOne(Guid productId, ProductUpdateDto product);

}
