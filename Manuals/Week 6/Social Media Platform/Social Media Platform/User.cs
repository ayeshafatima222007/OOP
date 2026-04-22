using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_Platform
{
    internal class User
    {
        private string Username;
        private List<Post> postlist;

        public User(string Username)
        {
            this.Username = Username;
            this.postlist = new List<Post>();
        }

        public string getUsername()
        {
            return Username;
        }

        public void setUsername(string Username)
        {
            this.Username = Username;
        }

        public List<Post> getPostlist()
        {
            return postlist;
        }

        public void AddPost(Post p)
        {
            postlist.Add(p);
        }
    }
}
