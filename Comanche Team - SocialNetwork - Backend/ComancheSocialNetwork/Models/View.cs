namespace ComancheSocialNetwork.Models
{
    public class View
    {
        public int Id { get; set; }

        public int ViewerId { get; set; }

        public User Viewer { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }

    }
}
