using Microsoft.AspNetCore.Mvc;
using Prefinal_Quiz.Models;

namespace Prefinal_Quiz.Controllers
{
    public class PortfolioController : Controller
    {
        private static List<Project> projects = new()
        {
            new Project
            {
                Id = 1,
                Title = "Test",
                Description = "A Windows Forms application designed to manage pharmacy sales, products, inventory, stock monitoring, and reports.",
                ImageUrl = "/images/cinema.png",
                GithubUrl = "https://github.com/eririii2/IT_ELECTIVE_2_BSIT31E1_PREFINAL_QUIZ_Ramones_LeisbethAnn.git",
                Technologies = "C#, Windows Forms, MySQL"
            }
        };

        private static List<Comment> comments = new();

        public IActionResult Index()
        {
            ViewBag.Comments = comments;

            return View(projects);
        }

        public IActionResult Details(int id)
        {
            var project = projects.FirstOrDefault(p => p.Id == id);

            if (project == null)
            {
                return NotFound();
            }

            ViewBag.Comments = comments
                .Where(c => c.ProjectId == id)
                .OrderByDescending(c => c.DatePosted)
                .ToList();

            return View(project);
        }

        [HttpPost]
        public IActionResult AddComment(
            int projectId,
            string name,
            string message)
        {
            if (!string.IsNullOrWhiteSpace(name) &&
                !string.IsNullOrWhiteSpace(message))
            {
                comments.Add(new Comment
                {
                    Id = comments.Count + 1,
                    ProjectId = projectId,
                    Name = name,
                    Message = message,
                    DatePosted = DateTime.Now
                });
            }

            return RedirectToAction("Details", new { id = projectId });
        }
    }
}