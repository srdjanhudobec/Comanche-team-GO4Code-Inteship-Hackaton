using ComancheSocialNetwork.Models;

namespace ComancheSocialNetwork.DTOs.Attachment
{
    public class AttachmentModelPostRequest
    {

        public string Content { get; set; }

        public string Type { get; set; }

        public int PostId { get; set; }

    }
}
