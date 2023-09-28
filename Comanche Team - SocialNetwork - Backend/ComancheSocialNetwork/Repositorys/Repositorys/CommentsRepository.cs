using ComancheSocialNetwork.Data;
using ComancheSocialNetwork.Models;
using ComancheSocialNetwork.Repositorys.Interfaces;

namespace ComancheSocialNetwork.Repositorys.Repositorys
{
    public class CommentsRepository : ICommentRepository
    {
        public readonly DatabaseContext _comments;

        public CommentsRepository(DatabaseContext comments)
        {
            _comments = comments;
        }
        public Comment addComment(Comment comment,string username)
        {
            User u = _comments.users.FirstOrDefault(x => x.Username == username);
            if (u != null)
            {
                comment.CreatorId = u.Id;
            }
            //Post p = _comments.posts.FirstOrDefault(x=> x.Id ==  comment.PostId);
            //p.comm
            if(comment != null)
            {
                _comments.comments.Add(comment);
                _comments.SaveChanges();
                return comment;
            }
            return null;
        }

        public Comment deleteComment(int id, string username)
        {
            User u = _comments.users.FirstOrDefault(x=>x.Username == username);
            Comment c = _comments.comments.FirstOrDefault(c => c.Id == id);
            if (u != null)
            {
                if(c.CreatorId != u.Id)
                {
                    return null;
                }
            }
            if (c != null)
            {
                _comments.comments.Remove(c);
                _comments.SaveChanges();
                return c;
            }
            return null;
        }

        public Comment getComment(int id)
        {
            Comment comment = _comments.comments.FirstOrDefault(c => c.Id == id);
            if(comment != null)
            {
                return comment;
            }
            return comment;
        }

        public Comment updateComment(string textComment, int id,string username)
        {
            User u = _comments.users.FirstOrDefault(x => x.Username == username);
            Comment c = getComment(id);
            if (u != null)
            {
                if (c.CreatorId != u.Id)
                {
                    return null;
                }
            }
            if (c != null)
            {
                c.CommentText = textComment;
                _comments.SaveChanges();
                return c;
            }
            return null;
        }
    }
}
