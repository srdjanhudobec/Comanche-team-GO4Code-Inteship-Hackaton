using ComancheSocialNetwork.DTOs.User;
using ComancheSocialNetwork.Models;

namespace ComancheSocialNetwork.Services.Interfaces
{
    public interface IUserService
    {
        public UserPostResponse createUser(UserPostRequest user);

        public List<UserGetResponse> getAllUsers();

    }
}
