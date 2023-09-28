using AutoMapper;
using ComancheSocialNetwork.DTOs.Comment;
using ComancheSocialNetwork.DTOs.Post;
using ComancheSocialNetwork.Models;
using ComancheSocialNetwork.Repositorys.Interfaces;
using ComancheSocialNetwork.Services.Interfaces;
using Microsoft.Extensions.Hosting;
using System.Xml.Linq;

namespace ComancheSocialNetwork.Services.Services
{
    public class PostService:IPostService
    {
        public readonly IPostRepository _posts;
        public readonly IMapper _mapper;
        public PostService(IPostRepository posts,IMapper mapper)
        {
            _posts = posts;
            _mapper = mapper;
        }

        public PostPostResponse createPost(PostPostRequest post,string username)
        {
            var response = _mapper.Map<PostPostResponse>(_posts.createPost(_mapper.Map<Post>(post), username));
            if (response == null)
            {
                return null;
            }
            return response;
        }

        public PostGetResponse deletePost(int id, string username)
        {
            var response = _mapper.Map<PostGetResponse>(_posts.deletePost(id, username));
            if (response == null)
            {
                return null;
            }
            return response;
        }

        public List<PostGetResponse> getPosts()
        {
            var response = _posts.getPosts();
            if (response == null)
            {
                return null;
            }
            return response;
        }
    }
}
