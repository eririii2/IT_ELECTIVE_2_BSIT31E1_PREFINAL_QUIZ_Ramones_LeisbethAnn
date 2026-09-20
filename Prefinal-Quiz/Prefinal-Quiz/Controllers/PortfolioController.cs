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
                Title = "[Student Management System – Procedural Core] Prelim - H1",
                Category = "Prelim",
                Description = "A console-based Student Management System developed using C#. The project demonstrates fundamental programming concepts such as variables, loops, conditionals, methods, and data structures through a menu-driven application.",
                ImageUrl = "/images/Prelim-H1.png",
                Technologies = "C#",
                GithubUrl = "https://github.com/eririii2/BSIT31E1_PRELIM_H1_RAMONES_LEISBETHANN.git"
            },

            new Project
            {
                Id = 2,
                Title = "[GitHub Desktop + Visual Studio + C# FizzBuzz Challenge] Prelim - Activity 1",
                Category = "Prelim",
                Description = "A C# console application that generates the FizzBuzz sequence from 1 to 100. The project applies conditional statements and loops to determine whether each number is divisible by 3, 5, or both.",
                ImageUrl = "/images/Prelim-Act1.png",
                Technologies = "C#",
                GithubUrl = "https://github.com/eririii2/BSIT31E1_Prelim_A1_Ramones-Leisbeth-Ann.git"
            },

            new Project
            {
                Id = 3,
                Title = "[Visual Studio Git Repository + GitHub Desktop + C# Calculator Challenge] Prelim - Activity 2",
                Category = "Prelim",
                Description = "A C# console-based calculator that accepts two numbers and performs basic arithmetic operations such as addition, subtraction, multiplication, and division. The application continuously accepts calculations until the user chooses to exit.",
                ImageUrl = "/images/Prelim-Act2.png",
                Technologies = "C#",
                GithubUrl = "https://github.com/eririii2/BSIT31E1_PRELIM_A2_RAMONESLEISBETHANN.git"
            },

            new Project
            {
                Id = 4,
                Title = "[File Ingestion Engine] Prelim - H2",
                Category = "Prelim",
                Description = "A C# application that implements different file reader classes for XML, JSON, and CSV files. The project demonstrates how different file formats can be handled through separate reader implementations.",
                ImageUrl = "/images/Prelim-H2.png",
                Technologies = "C#",
                GithubUrl = "https://github.com/eririii2/BSIT31E1_PRELIM_H2_Ramones_LeisbethAnn.git"
            },

            new Project
            {
                Id = 5,
                Title = "Prelim - H3",
                Category = "Prelim",
                Description = "A refactored version of the Student Management System that improves the structure and organization of the original application. The project uses classes, constructors, private member variables, and public methods to separate responsibilities and keep the main program cleaner.",
                ImageUrl = "/images/Prelim-H3.png",
                Technologies = "C#",
                GithubUrl = "https://github.com/EulloJohnRaven/BSIT31E1_PRELIM_H1_EULLO_JOHNRAVEN.git"
            },

            new Project
            {
                Id = 6,
                Title = "Prelim - Quiz 1",
                Category = "Prelim",
                Description = "A C# application that demonstrates object-oriented programming through classes, inheritance, interfaces, polymorphism, and a resolver/factory pattern. The application identifies different types of transportation, such as cars, airplanes, boats, and helicopters, and creates the appropriate objects based on the given input.",
                ImageUrl = "/images/Prelim-Quiz1.png",
                Technologies = "C#",
                GithubUrl = "https://github.com/eririii2/BSIT31E1_PRELIM_Q1_RAMONES_LEISBETH-ANN.git"
            },

            new Project
            {
                Id = 7,
                Title = "Prelim - Activity 3",
                Category = "Prelim",
                Description = "A C# console application that demonstrates communication with an API using HTTP methods. The project implements GET, POST, PUT, and DELETE requests to show how a console application can interact with web APIs.",
                ImageUrl = "/images/Prelim-Act3.png",
                Technologies = "C#",
                GithubUrl = "https://github.com/eririii2/BSIT31E1_PRELIM_H3_Ramones_LeisbethAnn.git"
            },

            new Project
            {
                Id = 8,
                Title = "[OOP & HttpClient Concepts] Prelim - Exam",
                Category = "Prelim",
                Description = "Its an Object-Oriented Programming and HttpClient concepts in C#. Itt covers the fundamental programming concepts related to object-oriented design and HTTP communication.",
                ImageUrl = "/images/Prelim-Exam.png",
                Technologies = "C#",
                GithubUrl = "https://github.com/eririii2/IT_ELECTIVE_2_PRELIM_EXAM_RAMONES_LEISBETH.git"
            },

            new Project
            {
                Id = 9,
                Title = "[Personal Portfolio ASP.NET Core MVC 1] Midterm - Activity 1",
                Category = "Midterm",
                Description = "A responsive personal portfolio website developed using ASP.NET Core MVC, demonstrating MVC architecture, Razor Views, shared layout customization, and responsive UI design using Bootstrap 5.",
                ImageUrl = "/images/Midterm-Act1.png",
                Technologies = "C#, ASP.NET Core MVC",
                GithubUrl = "https://github.com/eririii2/IT_ELECTIVE_2_Midterm_A1_Ramones_LeisbethAnn.git"
            },

            new Project
            {
                Id = 10,
                Title = "[Personal Portfolio ASP.NET Core MVC 2] Midterm - Activity 2",
                Category = "Midterm",
                Description = "A responsive personal portfolio website developed using ASP.NET Core MVC, applying MVC architecture, Razor Views, shared layout customization, and responsive user interface design using Bootstrap 5.",
                ImageUrl = "/images/Midterm-Act1.png",
                Technologies = "C#, ASP.NET Core MVC",
                GithubUrl = "https://github.com/eririii2/IT_ELECTIVE_2_Midterm_A1_Ramones_LeisbethAnn.git"
            },

            new Project
            {
                Id = 11,
                Title = "[Login Page] Midterm - Project",
                Category = "Midterm",
                Description = "A simple login application developed using ASP.NET Core MVC that demonstrates Model Binding, C# Models, Data Annotations, server-side validation, form submission, controller actions, and redirection. The application uses hard-coded login credentials without a database.",
                ImageUrl = "/images/Midterm-Project.png",
                Technologies = "C#, ASP.NET Core MVC",
                GithubUrl = "https://github.com/eririii2/-IT_ELECTIVE_BSIT_BSIT31E1_Ramones_LeisbethAnn.git"
            },

            new Project
            {
                Id = 12,
                Title = "[Playlist] Midterm - Quiz 2",
                Category = "Midterm",
                Description = "An authenticated ASP.NET Core MVC application that allows users to manage a YouTube playlist using server-rendered forms. The project demonstrates session-based authentication, Action Filters, DTOs, ModelState, indexed model binding, and in-memory data storage without a database.",
                ImageUrl = "/images/Midterm-Quiz2.png",
                Technologies = "C#, ASP.NET Core MVC",
                GithubUrl = "https://github.com/eririii2/-IT_ELECTIVE_2_MIDTERM_Q2_Ramones_LeisbethAnn.git"
            },

            new Project
            {
                Id = 13,
                Title = "Midterm - Quiz 3",
                Category = "Midterm",
                Description = "A login form application that limits users to three login attempts and requires a minimum of six characters for the input. The project demonstrates login validation and handling of incorrect user input.",
                ImageUrl = "/images/Midterm-Q3.png",
                Technologies = "C#, ASP.NET Core MVC",
                GithubUrl = "https://github.com/eririii2/IT_ELECTIVE_2_MIDTERM_Q3_Ramones_LeisbethAnn.git"
            },

            new Project
            {
                Id = 14,
                Title = "[Ramones' Tech Hardware] Midterm - H1, H2, H3",
                Category = "Midterm",
                Description = "An ASP.NET Core MVC Point of Sale web application designed for a small retail store. The system allows a cashier to browse products, manage a shopping cart, update or remove items, process customer checkout, record transactions, and manage inventory using in-memory repositories, DTOs, model binding, and server-side validation.",
                ImageUrl = "/images/Midterm-H1_H2_H3.png",
                Technologies = "C#, ASP.NET Core MVC",
                GithubUrl = "https://github.com/eririii2/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Ramones_LeisbethAnn.git"
            },

            new Project
            {
                Id = 15,
                Title = "[Vehicle Service Monitoring] Midterm - Exam",
                Category = "Midterm",
                Description = "A web-based Vehicle Service Monitoring System that allows users to register vehicles and monitor service jobs. The interface includes vehicle registration, service job searching, customer and vehicle information, service type, service bay, check-in time, release time, and service status.",
                ImageUrl = "/images/Midterm-Exam.png",
                Technologies = "C#, ASP.NET Core MVC",
                GithubUrl = "https://github.com/eririii2/IT_ELECTIVE_2_MIDTERM_EXAM_RAMONES_LEISBETHANN.git"
            },

            new Project
            {
                Id = 16,
                Title = "[Web System and Technologies Exam] Prefinal - Exam",
                Category = "Prefinal",
                Description = "A web-based Prefinal Examination, an already included questions and answers.",
                ImageUrl = "/images/Prefinal-Exam.png",
                Technologies = "C#, ASP.NET Core MVC",
                GithubUrl = "https://github.com/eririii2/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Ramones_LeisbethAnn.git"
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