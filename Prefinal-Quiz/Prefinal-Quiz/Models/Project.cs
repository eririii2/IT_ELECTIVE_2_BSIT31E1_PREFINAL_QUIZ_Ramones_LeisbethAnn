using Microsoft.AspNetCore.Mvc;

namespace Prefinal_Quiz.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Category { get; set; } = "";
        public string Description { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public string Technologies { get; set; } = "";
        public string GithubUrl { get; set; } = "";
    }
}