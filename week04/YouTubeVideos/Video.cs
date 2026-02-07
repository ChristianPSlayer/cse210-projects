using System;
namespace YouTubeVideos
{
    public class Video
    {
        private string _title;
        private string _author;
        private int _length;
        private List<Comment> _comments;
        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
            _comments = new List<Comment>();
        }

        public void AddComment(Comment newComment)
        {
            _comments.Add(newComment);
        }
        public int GetCommentCount()
        {
            return _comments.Count;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Length: {_length} seconds");
            Console.WriteLine($"Number of Comments: {GetCommentCount()}");
            Console.WriteLine("--- Comments ---");

           
            foreach (Comment c in _comments)
            {
                Console.WriteLine(c.GetDisplayText());
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine(); 
        }
    }
}
