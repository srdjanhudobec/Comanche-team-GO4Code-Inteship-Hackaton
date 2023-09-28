using AutoMapper;
using ComancheSocialNetwork.Data;
using ComancheSocialNetwork.DTOs.Comment;
using ComancheSocialNetwork.DTOs.Post;
using ComancheSocialNetwork.DTOs.User;
using ComancheSocialNetwork.Models;
using ComancheSocialNetwork.Repositorys.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Xml.Linq;

namespace ComancheSocialNetwork.Repositorys.Repositorys
{
    public class PostRepository:IPostRepository
    {
        public readonly DatabaseContext _posts;
        public readonly IMapper _mapper;

        public PostRepository(DatabaseContext posts,IMapper mapper)
        {
            _posts = posts;
            _mapper = mapper;
        }

        public Post createPost(Post post,string username)
        {
            User u = _posts.users.FirstOrDefault(x => x.Username == username);
            if(u!=null)
            {
                post.CreatorId = u.Id;
            }
            post.TimeCreated = DateTime.Now;
            if (post != null)
            {
                _posts.posts.Add(post);
                _posts.SaveChanges();
                return post;
            }
            return post;
        }

        public Post deletePost(int id, string username)
        {
            User u = _posts.users.FirstOrDefault(x => x.Username == username);
            Post p = _posts.posts.FirstOrDefault(c => c.Id == id);
            if (u != null)
            {
                if (p.CreatorId != u.Id)
                {
                    return null;
                }
            }
            if (p != null)
            {
                _posts.posts.Remove(p);
                _posts.SaveChanges();
                return p;
            }
            return null;
        }

        public List<PostGetResponse> getPosts()
        {
            List<Post> sviPostovi = _posts.posts.ToList();
            List<PostGetResponse> noviPostovi = new List<PostGetResponse>();
            List<Comment> sviKomentari = _posts.comments.ToList();
            foreach(var post in sviPostovi)
            {
                List<CommentPostGet> noviComentari = new List<CommentPostGet>();
                foreach (var comment  in sviKomentari)
                {
                    if(comment.PostId == post.Id)
                    {  
                        comment.Creator = _posts.users.FirstOrDefault(x => x.Id == comment.CreatorId);
                        _mapper.Map<UserCommentDTO>(comment.Creator);
                        noviComentari.Add(_mapper.Map<CommentPostGet>(comment));
                    }
                }
                foreach(var comment in noviComentari)
                {
                    _mapper.Map<UserCommentDTO>(comment.Creator);
                }
                PostGetResponse p = _mapper.Map<PostGetResponse>(post);
                p.Comments = noviComentari;
                noviPostovi.Add(p);
            }
            if (noviPostovi.Count > 0)
            {
                return noviPostovi.OrderByDescending(p => p.TimeCreated).ToList();
            }
            return null;
        }

        
    }
}
