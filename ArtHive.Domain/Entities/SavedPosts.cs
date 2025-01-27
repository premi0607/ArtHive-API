using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtHive.Domain.Entities
{
    public class SavedPosts
    {
        public int Id { get; set;}
        public int UserId { get; set;}
        public int PostId { get; set;}
        public DateTime SavedAt { get; set;}

        public Users Users { get; set; }
        public Posts Posts { get; set; }
    }
}
