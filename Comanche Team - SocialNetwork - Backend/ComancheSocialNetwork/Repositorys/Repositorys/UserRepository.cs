using ComancheSocialNetwork.Data;
using ComancheSocialNetwork.Models;
using ComancheSocialNetwork.Repositorys.Interfaces;

namespace ComancheSocialNetwork.Repositorys.Repositorys
{
    public class UserRepository: IUserRepository
    {
        public readonly DatabaseContext _users;
        public UserRepository(DatabaseContext context)
        {
            _users = context;
        }

        public UserRepository() { }

        public User createUser(User user)
        {
            if (user != null)
            {
                _users.Add(user);
                _users.SaveChanges();
                return user;
            }
            return null;
        }

        public List<User> getAllUsers()
        {
            return _users.users.ToList();
        }
    }
}
