namespace curso_csharp_udemy.Entities.StringBuilder
{
    public class Comment
    {
        public Comment()
        {
            
        }
        public Comment(string comments)
        {
            Comments = comments;
        }

        public string Comments { get; set; }
    }
}
