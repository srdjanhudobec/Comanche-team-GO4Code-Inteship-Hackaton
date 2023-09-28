using ComancheSocialNetwork.Models;

namespace ComancheSocialNetwork.DTOs.User
{
    public class UserPostRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Nickname { get; set; }
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
