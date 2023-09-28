using AutoMapper;
using ComancheSocialNetwork.Data;
using ComancheSocialNetwork.DTOs.Attachment;
using ComancheSocialNetwork.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace ComancheSocialNetwork.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentController : ControllerBase
    {
        private readonly IAttachmentModelService _attachments;


        public AttachmentController(IAttachmentModelService attachments)
        {
            _attachments = attachments;
        }


        [HttpGet("get-attachment")]
        
        public ActionResult<AttachmentModelGetResponse> getAttachment(int id)
        {
            var response = _attachments.getAttachment(id);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpPost("create-attachment")]

        public ActionResult<AttachmentModelPostResponse> createAttachment(AttachmentModelPostRequest attachment)
        {
            var response = _attachments.createAttachment(attachment);
            if (response == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }

        [HttpDelete("delete-attachment")]

        public ActionResult<AttachmentModelGetResponse> deleteAttachment(int id)
        {
            var response = _attachments.deleteAttachment(id);
            if (response == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
    }
}
