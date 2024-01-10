using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Model
{
    class Post
    {
        public int UserID { get; set; }
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public Post(int userId,int postID, string title, string content, DateTime createdAt)
        {
            this.UserID = userId;
            this.PostID = postID;
            this.Title = title;
            this.Content = content;
            this.CreatedAt = createdAt;
        }
    }
}
