using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.RavenDB.Model
{
    
    public class Blog
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<BlogPost> BlogPosts { get; set; }
    }

    public class BlogPost
    {
        public string Id { get; set; }
        public string BlogId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsPublished { get; set; }
        public List<BlogPostComments> BlogPostComments { get; set; }
    }

    public class BlogPostComments
    {
        public string Id { get; set; }
        public string BlogPostId { get; set; }
        public string Comment { get; set; }
        public string CreatedOn { get; set; }
        public string Username { get; set; }
    }

}