using ComancheSocialNetwork.Models;

namespace ComancheSocialNetwork.Repositorys.Interfaces
{
    public interface IUserRepository
    {
        public User createUser(User user);

        public List<User> getAllUsers();
    }
}
