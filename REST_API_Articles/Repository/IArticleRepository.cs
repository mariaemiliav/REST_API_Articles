using REST_API_for_Articles_Visoiu_Maria.Entity;

namespace REST_API_for_Articles_Visoiu_Maria.Repository
{
    public interface IArticleRepository
    {
        IEnumerable<Article> GetArticlesList();
        Article GetArticle(int id);
        void AddNewArticle(Article article);
        void UpdateArticle(int id, Article article);
        void DeleteArticle(int id);
    }
}
