using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtHive.Domain.Entities
{
    public class Posts
    {
        public int Id { get; set; }
        public int UserId { get; set; } // FK userId
        public string ImageUrl { get; set; }
        public string? Caption { get; set; }
        public string? ArtType {  get; set; }
        public DateTime? CreatedAt { get; set; }

        public Users User { get; set; }

    }
}
