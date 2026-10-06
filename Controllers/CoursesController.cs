using BootstrapApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapApp.Controllers
{
    public class CoursesController : Controller
    {
        private static List<Course> _courses = new List<Course>
        {
            new Course { Id = 1, Title = "Основы C#", Instructor = "Иванов А.П.", Duration = 40, Price = 12000, Level = "Beginner" },
            new Course { Id = 2, Title = "ASP.NET Core MVC", Instructor = "Петров С.В.", Duration = 60, Price = 18000, Level = "Intermediate" },
            new Course { Id = 3, Title = "Entity Framework Core", Instructor = "Сидоров Д.М.", Duration = 30, Price = 10000, Level = "Intermediate" },
            new Course { Id = 4, Title = "Архитектура веб-приложений", Instructor = "Козлов Е.Н.", Duration = 50, Price = 25000, Level = "Advanced" },
            new Course { Id = 5, Title = "JavaScript для начинающих", Instructor = "Смирнова О.И.", Duration = 35, Price = 9000, Level = "Beginner" },
            new Course { Id = 6, Title = "Микросервисы на .NET", Instructor = "Морозов В.К.", Duration = 80, Price = 35000, Level = "Advanced" }
        };

        public IActionResult Index()
        {
            return View(_courses);
        }
    }
}