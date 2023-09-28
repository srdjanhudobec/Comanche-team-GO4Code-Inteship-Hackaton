using AutoMapper;
using ComancheSocialNetwork.DTOs.Attachment;
using ComancheSocialNetwork.DTOs.Comment;
using ComancheSocialNetwork.Models;
using ComancheSocialNetwork.Repositorys.Interfaces;
using ComancheSocialNetwork.Services.Interfaces;
using System.Net.Mail;

namespace ComancheSocialNetwork.Services.Services
{
    public class CommentService:ICommentService
    {
        public readonly ICommentRepository _comments;
        public readonly IMapper _mapper;

        public CommentService(ICommentRepository comments, IMapper mapper)
        {
            _comments = comments;
            _mapper = mapper;
        }

        public CommentPostResponse createComment(CommentPostRequest comment,string username)
        {
            var response = _mapper.Map<CommentPostResponse>(_comments.addComment(_mapper.Map<Comment>(comment),username));
            if (response == null)
            {
                return null;
            }
            return response;
        }

        public CommentGetResponse deleteComment(int id,string username)
        {
            var response = _mapper.Map<CommentGetResponse>(_comments.deleteComment(id,username));
            if (response == null)
            {
                return null;
            }
            return response;
        }
        public CommentGetResponse getComment(int id)
        {
            var response = _mapper.Map<CommentGetResponse>(_comments.getComment(id));
            if (response == null)
            {
                return null;
            }
            return response;
        }

        public CommentGetResponse updateComment(string textComment, int id, string username)
        {
            var response = _mapper.Map<CommentGetResponse>(_comments.updateComment(textComment,id,username));
            if (response == null)
            {
                return null;
            }
            return response;
        }
    }
}
