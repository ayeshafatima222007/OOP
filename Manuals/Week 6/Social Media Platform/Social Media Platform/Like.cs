using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_Platform
{
    internal class Like
    {
        private string likedby;

        public Like (string likedby)
        {
            this.likedby = likedby;
        }

        public string getLikeby()
        {
            return likedby;
        }

        public void setLikeby(string likedby)
        {
            this.likedby=likedby;
        }
    }
}
