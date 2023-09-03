namespace curso_csharp_udemy.Entities.StringBuilder
{
    public class Post
    {
        public Post()
        {
            
        }
        public Post(DateTime date, string title, string content, int likes, List<Comment> comments)
        {
            Date = date;
            Title = title;
            Content = content;
            Likes = likes;
            Comments = comments;
        }

        public DateTime Date {  get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; }

        public override string ToString()
        {
            string comentarios = "";
            foreach (Comment comment in Comments)
            {
                comentarios += $@"
                                {comment.Comments}";
            }
            return $@"
                      Date: {Date},
                      Title: {Title}, 
                      Content: {Content},
                      Likes: {Likes}
                      Comments: {comentarios}
                     ";
        }
    }
}
