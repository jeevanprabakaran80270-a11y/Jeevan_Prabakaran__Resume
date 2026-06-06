using Microsoft.AspNetCore.Mvc;
using ResumeWebsite.Models;
using System.Diagnostics;

namespace ResumeWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new ResumeViewModel
            {
                Name = "Jeevan Prabakaran",

                Title = "Software Developer",

                Summary = "Experienced Software Developer with 4 years of experience in .NET, ASP.NET, SQL Server, Mobile Applications, Web Applications and REST API development.",

                Phone = "9787336317",

                Email = "jeevanprabkaran@gmail.com",

                Education10th = "Government School - 75%",

                Education12th = "Government School - 70%",

                Experience = "Software Developer (2022 - 2026)",

                Frameworks = new List<string>
                {
                    ".NET",
                    "ASP.NET"
                },

                Languages = new List<string>
                {
                    "C#",
                    "HTML",
                    "CSS",
                    "Bootstrap",
                    "JavaScript"
                },

                Databases = new List<string>
                {
                    "Microsoft SQL Server"
                },

                Platforms = new List<string>
                {
                    "Web Applications",
                    "Android",
                    "iOS",
                    "REST API"
                },

                Projects = new List<ProjectModel>
                {
                    new ProjectModel
                    {
                        Name = "Banking Application",
                        Description = "Cross-platform banking application developed using .NET technologies.",
                        GithubUrl = "https://github.com/yourusername/banking-app"
                    },


                    new ProjectModel
                    {
                        Name = "REST API Platform",
                        Description = "ASP.NET Core API solution with SQL Server backend.",
                        GithubUrl = "https://github.com/yourusername/api-platform"
                    },

                    new ProjectModel
                    {
                        Name = "Mobile Banking App",
                        Description = "Android and iOS banking application built with .NET MAUI.",
                        GithubUrl = "https://github.com/yourusername/mobile-app"
                    }
                }
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0,
                       Location = ResponseCacheLocation.None,
                       NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ??
                            HttpContext.TraceIdentifier
            });
        }
    }
}