namespace WebApplication1.Models
{
    public class Data
    {
        public static List<Post> Posts = new List<Post>
        {
            new Post
            {
                Id = 1, Title = "Test Title" , Content = "Test Content"
                ,Author = "Mohammed" , Slug = "Test Slug" 
            }
        };
    }
}
