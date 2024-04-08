using REST_API_for_Articles_Visoiu_Maria.Entity;

namespace REST_API_for_Articles_Visoiu_Maria.Data
{
    public static class ArticleData
    {
        public static List<Article> Articles { get; } = new List<Article>
        {
            new Article { Id = 1, Title = "About AI", Content = "An overview of artificial intelligence", PublishedDate = DateTime.UtcNow },
            new Article { Id = 2, Title = "The future of software development", Content = "The Future of Software Development: Trends to Watch in 2024", PublishedDate = new DateTime(2023, 9, 27) },
            new Article { Id = 3, Title = "The future of Robotics", Content = "The Future of Robotics: Will Robots Take Over the World", PublishedDate = new DateTime(2024, 2, 29) }
        };
    }
}
