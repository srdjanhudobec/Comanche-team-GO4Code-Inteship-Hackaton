using ComancheSocialNetwork.DTOs.Comment;
using ComancheSocialNetwork.Models;
using ComancheSocialNetwork.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace ComancheSocialNetwork.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        public readonly ICommentService _comments;

        public CommentController(ICommentService comments)
        {
            _comments = comments;
        }

        [HttpGet("get-comment")]

        public ActionResult<CommentGetResponse> getComment(int id)
        {
            var response = _comments.getComment(id);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpPost("create-comment")]

        public ActionResult<CommentPostResponse> createComment(CommentPostRequest comment)
        {
            var response = _comments.createComment(comment,User.Identity.Name);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpDelete("delete-comment")]

        public ActionResult<CommentGetResponse> deleteComment(int id) {
            var response = _comments.deleteComment(id,User.Identity.Name);
            if (response == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }

        [HttpPut("update-comment")]

        public ActionResult<CommentGetResponse> updateComment(string textComment,int id)
        {
            var response = _comments.updateComment(textComment,id, User.Identity.Name);
            if (response == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
    }
}
