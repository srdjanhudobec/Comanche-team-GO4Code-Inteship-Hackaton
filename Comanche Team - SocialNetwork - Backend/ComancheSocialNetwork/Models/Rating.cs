namespace ComancheSocialNetwork.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public int CreatorId { get;set; }

        public User Creator { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }

        public int RatingValue { get; set; }

    }
}
