using AutoMapper;
using ComancheSocialNetwork.DTOs.Post;
using ComancheSocialNetwork.Models;

namespace ComancheSocialNetwork.Profiles
{
    public class PostProfile:Profile
    {
        public PostProfile()
        {
            CreateMap<Post, PostPostRequest>();
            CreateMap<PostPostRequest, Post>();
            CreateMap<PostPostResponse, Post>();
            CreateMap<Post, PostPostResponse>();
            CreateMap<Post, PostGetResponse>();
            CreateMap<PostGetResponse, Post>();

        }
    }
}
