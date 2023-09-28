using ComancheSocialNetwork.Data;
using ComancheSocialNetwork.DTOs.Post;
using ComancheSocialNetwork.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComancheSocialNetwork.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        public readonly IPostService _posts;
        public readonly DatabaseContext _database;

        public PostController(IPostService posts,DatabaseContext database)
        {
            _posts = posts;
            _database = database;
        }

        [HttpPost("create-post")]

        public ActionResult<PostPostResponse> createPost(PostPostRequest post)
        {
            var response = _posts.createPost(post, User.Identity.Name);
            if(response ==  null)
            {
                return BadRequest();
            }
            response.TimeCreated.ToString("MM/dd/yyyy h:mm tt");
            return Ok(new { response,
                User.Identity.Name 
            });
        }

        [HttpGet("get-posts")]

        public ActionResult<List<PostGetResponse>> getPosts()
        {
            var response = _posts.getPosts();
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpDelete("delete-post")]

        public ActionResult<PostGetResponse> deletePost(int id)
        {
            var response = _posts.deletePost(id,User.Identity.Name);
            if (response == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
    }
}
