using AutoMapper;
using ComancheSocialNetwork.DTOs.User;
using ComancheSocialNetwork.Models;

namespace ComancheSocialNetwork.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile() {

            CreateMap<User, UserPostRequest>();
            CreateMap<UserPostRequest, User>();
            CreateMap<User, UserPostResponse>();
            CreateMap<UserPostResponse, User>();
            CreateMap<User, UserGetResponse>();
            CreateMap<UserGetResponse, User>();
            CreateMap<UserCommentDTO, User>();
            CreateMap<User, UserCommentDTO>();
        }
    }
}
