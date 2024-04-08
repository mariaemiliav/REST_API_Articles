using REST_API_for_Articles_Visoiu_Maria.Data;
using REST_API_for_Articles_Visoiu_Maria.Entity;

namespace REST_API_for_Articles_Visoiu_Maria.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        public IEnumerable<Article> GetArticlesList()
        {
            return ArticleData.Articles;
        }

        public Article GetArticle(int id)
        {
            return ArticleData.Articles.FirstOrDefault(a => a.Id == id);
        }

        public void AddNewArticle(Article article)
        {
            article.Id = ArticleData.Articles.Count + 1;
            article.PublishedDate = DateTime.Now;
            ArticleData.Articles.Add(article);
        }

        public void UpdateArticle(int id, Article article)
        {
            var existingArticle = ArticleData.Articles.FirstOrDefault(a => a.Id == id);
            if (existingArticle != null)
            {
                existingArticle.Title = article.Title;
                existingArticle.Content = article.Content;
                existingArticle.PublishedDate = article.PublishedDate;
            }
        }

        public void DeleteArticle(int id)
        {
            var article = ArticleData.Articles.FirstOrDefault(a => a.Id == id);
            ArticleData.Articles.Remove(article);
        }
    }
}
