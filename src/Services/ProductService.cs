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
    // public IEnumerable<ProductDTO> FindAll(int limit, int offset)
    // {
    //     IEnumerable<Product> products = _ProductRepository.FindAll(limit, offset);
    //     return products.Select(_mapper.Map<ProductDTO>);
    // }

    public IEnumerable<ProductReadDTO> FindAll(string? searchBy)
    {
        var products = _ProductRepository.FindAll(searchBy);
        if(searchBy is not null)
    {
        products = products.Where(product => product.Name.ToLower().Contains(searchBy.ToLower()));   
    }

        var productRead =  products.Select(_mapper.Map<ProductReadDTO>);
        return productRead;
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

    public bool DeleteById(Guid id){
        return _ProductRepository.DeleteById(id);
    }


    public ProductReadDTO UpdateOne(Guid productId, ProductUpdateDto updatedProduct)
        {
            var product = _ProductRepository.FindeOne(productId);
            //ToDo: implement if  statement for each property in product to check if it exists before updating
            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.CategoryId = updatedProduct.CategoryId;
                _ProductRepository.UpdateOne(product);

                return _mapper.Map<ProductReadDTO>(product);
            }
            return null;
        }

}
