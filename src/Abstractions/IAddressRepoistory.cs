using Hanan_csharp_backend_teamwork.src.Entities;
namespace Hanan_csharp_backend_teamwork.src.Abstractions;
public interface IAddressRepoistory
{
    public IEnumerable<Address> FindAll();
    public Address? FindOne(Guid id);
    public bool DeleteById(Guid id);
    public Address CreateOne(Address userAddress);
}
