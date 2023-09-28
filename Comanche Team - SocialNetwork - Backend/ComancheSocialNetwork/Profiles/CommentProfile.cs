using AutoMapper;
using ComancheSocialNetwork.DTOs.Comment;
using ComancheSocialNetwork.Models;

namespace ComancheSocialNetwork.Profiles
{
    public class CommentProfile:Profile
    {
        public CommentProfile()
        {
            CreateMap<Comment, CommentGetResponse>();
            CreateMap<CommentGetResponse, Comment>();
            CreateMap<Comment, CommentPostRequest>();
            CreateMap<CommentPostRequest, Comment>();
            CreateMap<Comment, CommentPostResponse>();
            CreateMap<CommentPostResponse, Comment>();
            CreateMap<CommentPostGet, Comment>();
            CreateMap<Comment, CommentPostGet>();
        }
    }
}
