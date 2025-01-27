using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtHive.Domain.Entities
{
    public class Comments
    {
        public int Id {  get; set; }
        public int PostId { get; set; } // FK post
        public int UserId { get; set; } // FK user
        public int ParentCommentID {  get; set; } // for replies (references Comments => ID)
        public string CommentText { get; set; }
        public DateTime commented_At { get; set; }

    }
}
