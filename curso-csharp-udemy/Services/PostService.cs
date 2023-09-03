using curso_csharp_udemy.Entities.StringBuilder;

namespace curso_csharp_udemy.Services
{
    public class PostService
    {
        public void Handle()
        {
            var post1 = new Post(
                date: new DateTime(2018,06,21,13,05,44),
                title: "Traveling to new Zealand",
                content: "I'm going to visit this wonderful country!",
                likes: 12,
                comments: new List<Comment>()
                {
                    new Comment("Have a nice trip"),
                    new Comment("Wow that's awesome!")
                });


            var post2 = new Post(
                date: new DateTime(2018, 07, 28, 23, 14, 19),
                title: "Good night guys",
                content: "See you tomorrow",
                likes: 5,
                comments: new List<Comment>()
                {
                    new Comment("Good night"),
                    new Comment("May the force be with you")
                });

            Console.WriteLine(post1.ToString());
            Console.WriteLine(post2.ToString());
        }
    }
}
