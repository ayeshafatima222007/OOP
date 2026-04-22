using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_Platform
{
    internal class Post
    {
        private string PostText;

        private List<Comment> commentlist;
        private List<Like> likelist;

        public Post(string PostText)
        {
            this.PostText = PostText;
            this.commentlist = new List<Comment>();
            this.likelist = new List<Like>();
        }

        public string getPostText()
        {
            return PostText;
        }

        public void setPostText(string PostText)
        {
            this.PostText = PostText;
        }

        public List<Comment> getCommentlist()
        {
            return commentlist;
        }

        public List<Like> getLikelist()
        {
            return likelist;
        }

        public void AddComment(Comment c)
        {
            commentlist.Add(c);
        }
        public void AddLike(Like l)
        {
            likelist.Add(l);
        }
    }
}
