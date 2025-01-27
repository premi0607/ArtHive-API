using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtHive.Domain.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Created_At { get; set; }

        public ICollection<Posts> Posts { get; set; } = new List<Posts>();
        public ICollection<Likes> Likes { get; set; } = new List<Likes>();
        public ICollection<SavedPosts> SavedPosts { get; set; } = new List<SavedPosts>();
    }
}
