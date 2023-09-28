using AutoMapper;
using ComancheSocialNetwork.DTOs.User;
using ComancheSocialNetwork.Models;
using ComancheSocialNetwork.Repositorys.Interfaces;
using ComancheSocialNetwork.Services.Interfaces;

namespace ComancheSocialNetwork.Services.Services
{
    public class UserService:IUserService
    {
        public readonly IUserRepository _users;
        public readonly IMapper _mapper;

        public UserService(IUserRepository users, IMapper mapper)
        {
            _users = users;
            _mapper = mapper;
        }
        public UserPostResponse createUser(UserPostRequest user)
        {
            var response = _mapper.Map<UserPostResponse>(_users.createUser(_mapper.Map<User>(user)));
            if (response == null)
            {
                return null;
            }
            return response;
        }

        public List<UserGetResponse> getAllUsers()
        {
            var response = _mapper.Map<List<UserGetResponse>>(_users.getAllUsers());
            if (response == null)
            {
                return null;
            }
            return response;
        }
    }
}
