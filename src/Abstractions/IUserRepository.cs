using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IUserRepository
    {
        public List<User> FindAll();
        public User CreateOne(User user);
        public User? FindOneByEmail(string email);
        public User UpdateOne(User updateUser);


       // public User? FindOneById(string Id);



    }
}