namespace ComancheSocialNetwork.Models
{
    public class AttachmentModel
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string Type { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }
    }
}
