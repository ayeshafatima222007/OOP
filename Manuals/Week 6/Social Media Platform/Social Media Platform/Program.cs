using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_Platform
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************");
            Console.WriteLine("*   Social Media Platform    *");
            Console.WriteLine("******************************");

            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            User u = new User(username);

            int post;
            while (true)
            {
                Console.Write("Enter the no. of posts you want to add: ");

                if (int.TryParse(Console.ReadLine(),out post))
                {
                    break;
                }
                else
                {
                    Console.Write("Enter a valid no.!!");
                }
            }

            for (int i = 0; i < post; i++)
            {

                Console.Write("Enter Post Text you want to write: ");
                string PostText = Console.ReadLine();

                Post p = new Post(PostText);

                int CommentNo;
                while (true)
                {
                    Console.Write("Enter the no. of comments you want to comment: ");

                    if (int.TryParse(Console.ReadLine(), out CommentNo))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Enter a valid no.!!");
                    }
                }

                for(int j = 0 ; j<CommentNo; j++)
                {
                    Console.Write(" Who is commenting: ");
                    string Commentby = Console.ReadLine();

                    Console.Write("Write Comment Text: ");
                    string CommentText = Console.ReadLine();

                    Comment c = new Comment(Commentby,CommentText);

                    p.AddComment(c);
                }

                int LikeNo;
                while (true)
                {
                    Console.Write("Enter the no of likes: ");

                    if (int.TryParse(Console.ReadLine(), out LikeNo))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Enter a valid no.!!\n");
                    }
                }

                for (int k =0 ; k<LikeNo; k++)
                {
                    Console.Write(" Who is liking this post: ");
                    string likedby = Console.ReadLine();

                    Like l = new Like (likedby);

                    p.AddLike(l);
                }

                u.AddPost(p);

            }

            //display output
            foreach (Post p in u.getPostlist())
            {
                Console.WriteLine($"\nPost: {p.getPostText()}");

                Console.WriteLine("Comments:");
                foreach (Comment c in p.getCommentlist())
                {
                    Console.WriteLine($"  {c.getCommentby()}: {c.getCommentText()}");
                }

                Console.WriteLine("Likes:");
                foreach (Like l in p.getLikelist())
                {
                    Console.WriteLine($"  {l.getLikeby()}");
                }
            }

        }
    }
}
