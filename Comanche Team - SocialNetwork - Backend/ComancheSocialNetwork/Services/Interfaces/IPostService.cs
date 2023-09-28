using ComancheSocialNetwork.DTOs.Post;

namespace ComancheSocialNetwork.Services.Interfaces
{
    public interface IPostService
    {
        public PostPostResponse createPost(PostPostRequest post,string username);

        public List<PostGetResponse> getPosts();

        public PostGetResponse deletePost(int id,string username);
    }
}
