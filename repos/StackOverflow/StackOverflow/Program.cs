using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Title : ");
            Post post = new Post (Console.ReadLine() , DateTime.Now);

            Console.WriteLine("Description : ");
            post.Description = Console.ReadLine();

            try
            {
                while (true)
                {
                    Console.WriteLine("\nPost :" + post.ShowPosts + " \nPosted : " + post.DatePost +" \n\nVote\n1 - Like \n2 - Dislike  \n3 - Show Votes \n4 - exit \nLikes :" + post.likesCount() + "    Dislikes :" + post.dislikesCount());


                    var vote = Convert.ToInt32(Console.ReadLine());

                    if (vote == 1)
                    {
                        post.VoteUP();

                    }
                    if (vote == 2)
                    {
                        post.VoteDown();
                    }
                    if (vote == 3)
                    {
                        Console.WriteLine("Likes :" + post.likesCount() + "    Dislikes :" + post.dislikesCount());
                    }
                    if (vote == 4)
                    {
                        return;
                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Some exception" );
                return;
            }
            

            

        }
    }
}
