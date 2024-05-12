using Hanan_csharp_backend_teamwork.src.Abstractions;
using Hanan_csharp_backend_teamwork.src.Entities;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
namespace Hanan_csharp_backend_teamwork.src.Repositories;

public class AddressRepository : IAddressRepoistory
{
    private DatabaseContext _databaseContext;
    private DbSet<Address> _addresses;
    public AddressRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
        _addresses = _databaseContext.Address;
    }
    public Address CreateOne(Address userAddress)
    {
        _addresses.Add(userAddress);
        _databaseContext.SaveChanges();
        return userAddress;
    }

    public Address? FindOne(Guid id)
    {
        return _addresses.FirstOrDefault(item => item.UserId == id);
    }

    public bool DeleteById(Guid id)
    {
        Address? address = FindOne(id);
        if (address is null)
        {
            return false;
        }
        else
        {
            _addresses.Remove(address);
            _databaseContext.SaveChanges();
            return true;
        }
    }

    public IEnumerable<Address> FindAll()
    {
        return _addresses;
    }
}

