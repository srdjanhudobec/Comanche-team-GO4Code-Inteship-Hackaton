using ComancheSocialNetwork.DTOs.Comment;
using System.Net.Mail;

namespace ComancheSocialNetwork.Models
{
    public class Post
    {
        public int Id { get; set; }

        public DateTime TimeCreated { get; set; }

        public int CreatorId { get; set; }

        public User Creator { get; set; }

        public string PostText { get; set; }

        public int AttacmentId { get; set; }

        public AttachmentModel Attachment { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Label> Labels { get; set; }

        public List<Rating> Rating { get; set; }

        public List<View> Views { get; set; } 


    }
}
