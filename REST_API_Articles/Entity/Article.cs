﻿namespace REST_API_for_Articles_Visoiu_Maria.Entity
{
    public class Article
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
