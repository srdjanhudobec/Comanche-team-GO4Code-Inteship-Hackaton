namespace ComancheSocialNetwork.DTOs.Attachment
{
    public class AttachmentModelGetResponse
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public string Type { get; set; }

        public int PostId { get; set; }
    }
}
