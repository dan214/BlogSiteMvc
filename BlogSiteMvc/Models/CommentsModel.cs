using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSiteMvc.Models
{
    public class CommentsModel
    {
        public string CommentName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Message { get; set; }
        public int BlogItemId { get; set; }
    }
}