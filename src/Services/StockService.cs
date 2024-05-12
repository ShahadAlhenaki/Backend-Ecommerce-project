using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
namespace sda_onsite_2_csharp_backend_teamwork.src.Services;

public class StockService : IStockService
{
    private IStockRepository _stockRepository;
    private IMapper _mapper;
    public StockService(IStockRepository stockRepository, IMapper mapper)
    {
        _stockRepository = stockRepository;
        _mapper = mapper;
    }

    public Stock CreateOne(StockCreateDto newCreateStock)
    {
        Stock newStock = _mapper.Map<Stock>(newCreateStock);
        return _stockRepository.CreateOne(newStock);
    }
    public IEnumerable<Stock> FindAll()
    {
        return _stockRepository.FindAll();
    }

    public IEnumerable<Stock> FindByProductId(Guid productId)
    {
        return _stockRepository.FindByProductId(productId);
    }
    public Stock? FindById(Guid id)
    {
        return _stockRepository.FindById(id);
    }

    public bool DeleteOneById(Guid id)
    {
        return _stockRepository.DeleteOneById(id);
    }
    public bool DeleteProductById(Guid productId)
    {
        return _stockRepository.DeleteProductById(productId);
    }

    public Stock UpdateOne(Stock stock)
    {
        return _stockRepository.UpdateOne(stock);
    }
}
