using REST_API_for_Articles_Visoiu_Maria.Repository;

namespace REST_API_Articles
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IArticleRepository, ArticleRepository>();
        }
    }
}
