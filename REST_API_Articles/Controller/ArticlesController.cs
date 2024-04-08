using Microsoft.AspNetCore.Mvc;
using REST_API_for_Articles_Visoiu_Maria.Entity;
using REST_API_for_Articles_Visoiu_Maria.Repository;

namespace REST_API_for_Articles_Visoiu_Maria.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleRepository _articleRepository;

        public ArticlesController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        [HttpGet]
        public IActionResult GetArticles()
        {
            var articles = _articleRepository.GetArticlesList();
            return Ok(articles);
        }

        [HttpGet("{id}")]
        public IActionResult GetArticle(int id)
        {
            var article = _articleRepository.GetArticle(id);
            if (article == null)
                return NotFound();

            return Ok(article);
        }

        [HttpPost]
        public IActionResult AddNewArticle([FromBody] Article article)
        {
            if (article == null)
                return BadRequest("The article is not valid!");

            _articleRepository.AddNewArticle(article);

            string message = "The article was added with success";
            var response = new { Message = message, Article = article };

            return Ok(response);
        }


        [HttpPut("{id}")]
        public IActionResult PutArticle(int id, [FromBody] Article article)
        {
            if (article == null || id != article.Id)
                return BadRequest("Invalid article!");

            var existingArticle = _articleRepository.GetArticle(id);
            if (existingArticle == null)
                return NotFound("The article is not valid!");

            _articleRepository.UpdateArticle(id, article);
            return Ok("The article was updated with success!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteArticle(int id)
        {
            var article = _articleRepository.GetArticle(id);
            if (article == null)
                return NotFound("The article is not valid!");

            _articleRepository.DeleteArticle(id);
            return Ok("The article was deleted with success!");
        }
    }
}
