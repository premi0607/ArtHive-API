using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtHive.Domain.Entities
{
    public class Notifications
    {
        public int Id {  get; set; } //ID Required? - yet to confirm
        public int UsetId { get; set; }
        public string type { get; set; } // for -> like/comment/saved?
        public int ReferenceId { get; set; } // id of like/comment...
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
