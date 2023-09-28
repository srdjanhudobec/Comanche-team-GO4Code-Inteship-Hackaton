using ComancheSocialNetwork.DTOs.Post;
using ComancheSocialNetwork.Models;

namespace ComancheSocialNetwork.Repositorys.Interfaces
{
    public interface IPostRepository
    {
        public Post createPost(Post post,string username);

        public List<PostGetResponse> getPosts();

        public Post deletePost(int id,string username);
    }
}
