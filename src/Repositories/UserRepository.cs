using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

public class UserRepository : IUserRepository
{
    private DbSet<User> _users;
    private DatabaseContext _databaseContext;

    public UserRepository(DatabaseContext databaseContext)
    {
        _users = databaseContext.User;
        _databaseContext = databaseContext;
    }

    public IEnumerable<User> FindAll()
    {
        return _users;
    }

    public User CreateOne(User user)
    {
        _users.Add(user);
        _databaseContext.SaveChanges();
        return user;
    }
    public User? FindOneByEmail(string email)
    {
        User? user = _users.FirstOrDefault(user => user.Email == email);
        return user;
    }

    public User UpdateOne(User updateUser)
    {
        //    var users =  _users.Select(user => {
        //         if(user.Email == updateUser.Email)
        //         {
        //             return updateUser;
        //         }
        //         return user;
        //     });
        //     _users = users.ToList();

        return updateUser;
    }

    // public void DeleteOne(User user)
    // {
    //         _users.Remove(user);
    //         _databaseContext.SaveChanges();
        
    // }
    

    //     public User? FindOneById(string id)
    // {
    //     User? user = _users.FirstOrDefault(user => user.Id = id);
    //     return user;
    // }

    // public IEnumerable<User> DeleteUsersById(Guid id)
    // {
    //     User? faondUser = _users.Select((u) => u.Id != id);
    //     return _users;
    // }
}