using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
namespace sda_onsite_2_csharp_backend_teamwork.src.services;

public class ProductService : IProductService
{
    private IProductRepository _ProductRepository;
    private IMapper _mapper;
    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _ProductRepository = productRepository;
        _mapper = mapper;
    }
    public IEnumerable<ProductDTO> FindAll(int limit, int offset)
    {
        IEnumerable<Product> products = _ProductRepository.FindAll(limit, offset);
        return products.Select(_mapper.Map<ProductDTO>);
    }
    public ProductDTO? FindeOne(Guid Id)
    {
        var findProduct = _ProductRepository.FindeOne(Id);
        return _mapper.Map<ProductDTO>(findProduct);


    }
    public ProductDTO CreateOne(ProductReadDTO product)
    {
        Product creatProduct = _mapper.Map<Product>(product);
        return _mapper.Map<ProductDTO>(_ProductRepository.CreateOne(creatProduct));
    }
}
