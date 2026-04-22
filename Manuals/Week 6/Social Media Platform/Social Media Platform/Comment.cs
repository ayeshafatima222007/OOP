using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_Platform
{
    internal class Comment
    {
        private string Commentby;
        private string CommentText;

        public Comment(string Commentby, string CommentText)
        {
            this.Commentby = Commentby;
            this.CommentText = CommentText;
        }

        public string getCommentby()
        {
            return Commentby;
        }

        public void setCommentby(string Commentby)
        {
            this.Commentby = Commentby;
        }

        public string getCommentText()
        {
            return CommentText;
        }

        public void setCommentText(string CommentText)
        {
            this.CommentText = CommentText;
        }
    }
}
