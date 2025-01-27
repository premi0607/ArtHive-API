using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtHive.Domain.Entities
{
    public class Likes
    {
        public int PostId { get; set; } // FK post
        public int UserId { get; set; } // FK user
        public DateTime LikedAt { get; set; }

        public Users Users { get; set; }
        public Posts Posts { get; set; }

    }
}
