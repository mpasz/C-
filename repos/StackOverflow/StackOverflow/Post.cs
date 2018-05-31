using System;

namespace StackOverflow
{
    class Post
    {
        public Post(string title, DateTime postDate)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new NullReferenceException("Title can not be empty!");

            Title = title;
            PostDate = postDate;
        }

        public string Title { get; private set; }
        public DateTime PostDate { get; }
        private string _description;
        
        private int likes = 0;
        private int dislikes = 0;


        public string Description
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new NullReferenceException("Description can not be empty!");
                _description = value;
            }
            get { return _description; }
        }
        
        public void VoteUP()
        {
            likes++;
        }

        public void VoteDown()
        {
            dislikes++;
        }

        public int likesCount()
        {
            return likes;
        }

        public int dislikesCount()
        {
            return dislikes;
        }

        public string ShowPosts
        {
            get
            {
                var Allpost = Title + '\n' + Description;
                return Allpost; 
            }
        }

        public DateTime DatePost
        {
            get
            {
                return PostDate;
            }
        }
    }
}
