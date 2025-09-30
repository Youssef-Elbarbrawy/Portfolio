using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
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
            var portfolioData = GetPortfolioData();
            return View(portfolioData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private PortfolioViewModel GetPortfolioData()
        {
            return new PortfolioViewModel
            {
                PersonalInfo = new PersonalInfo
                {
                    Name = "Youssef Mohammad",
                    Title = ".NET Back-End Developer",
                    Location = "Cairo, Egypt",
                    Email = "youssefmohammad000@gmail.com",
                    LinkedIn = "www.linkedin.com/in/youssef-mohammad10",
                    GitHub = "github.com/Youssef-Elbarbrawy",
                    Phone = "+201011222194",
                    Summary = "Recent Business Information Systems graduate from Helwan University specializing in .NET development and back-end solutions. Experienced in solving complex problems and delivering efficient software applications through hands-on project experience. Proficiency in ASP.NET Core, C#, Entity Framework, and SQL enables effective delivery across Software Development Lifecycle from requirements analysis to deployment.",
                    ProfileImagePath = "/images/profile/youssef-profile.jpg"
                },
                Projects = new List<Project>
                {
                    new Project
                    {
                        Name = "ILLVent - Comprehensive Healthcare Platform",
                        Description = "Full-Stack Healthcare Management System built with ASP.NET Core MVC, EF Core, SignalR, Clean Architecture",
                        LongDescription = "A comprehensive healthcare platform providing real-time emergency system using SignalR for live hospital notifications, and ambulance dispatch coordination with geographic proximity algorithms. Built real-time employee tracking for appointment management with QR code generation, AES encryption, appointment booking system across 8+ specialties, and full e-commerce platform with Stripe payment integration for 30+ products.",
                        Technologies = new List<string> { "C#", "ASP.NET Core MVC", "EF Core", "SignalR", "Clean Architecture", "Authentication", "Authorization", "JWT", "QR Code Generation", "Stripe Integration", "Geographic Algorithms" },
                        GitHubUrl = "https://github.com/Youssef-Elbarbrawy/ILLVentApp",
                        StartDate = "Mar 2025",
                        EndDate = "Jun 2025",
                        Type = ProjectType.FullStack,
                        KeyFeatures = new List<string>
                        {
                            "Real-time emergency notifications with SignalR",
                            "Ambulance dispatch with geographic proximity algorithms",
                            "Appointment booking system across 8+ specialties",
                            "E-commerce platform with Stripe payment integration",
                            "Employee tracking with QR code generation",
                            "AES encryption for secure data handling",
                            "Clean Architecture implementation",
                            "Comprehensive authentication and authorization"
                        },
                        ImagePaths = new List<string> { 
                            "/images/illvent/swagger-1.jpg", 
                            "/images/illvent/swagger-2.jpg", 
                            "/images/illvent/swagger-3.jpg", 
                            "/images/illvent/swagger-4.jpg", 
                            "/images/illvent/swagger-5.jpg", 
                            "/images/illvent/swagger-6.jpg",
                            "/images/illvent/swagger-7.jpg"
                        }
                    },
                    new Project
                    {
                        Name = "Company Administration Service",
                        Description = "Secure MVC application using ASP.NET Core and Entity Framework Core, implementing role-based access control",
                        LongDescription = "Developed secure MVC application using ASP.NET Core and Entity Framework Core, implementing role-based access control with 3 roles: Admin (full access), HR (employee/department), and User (view-only for employees/departments). Utilized Generic Repository Pattern, EF Core with SQL Server managing 12+ database tables, AutoMapper for object mapping, comprehensive API documentation with Swagger/OpenAPI, and robust data validation ensuring data integrity. Demonstrates proficiency in back-end development, CRUD operations, and secure data management.",
                        Technologies = new List<string> { "C#", "ASP.NET Core", "Entity Framework Core", "SQL Server", "AutoMapper", "Swagger/OpenAPI", "Generic Repository Pattern", "Role-based Access Control", "CRUD Operations", "Data Validation" },
                        GitHubUrl = "https://github.com/Youssef-Elbarbrawy/CompanyAminstrationMVC",
                        VideoUrl = "/images/companyadmin/CompanyAdminVideo.mp4", // Company Administration demo video
                        StartDate = "Sep 2024",
                        EndDate = "Oct 2024",
                        Type = ProjectType.WebApplication,
                        KeyFeatures = new List<string>
                        {
                            "Role-based access control (Admin, HR, User)",
                            "Generic Repository Pattern implementation",
                            "Entity Framework Core with SQL Server",
                            "AutoMapper for efficient object mapping",
                            "Comprehensive API documentation",
                            "Robust data validation and integrity",
                            "12+ database tables management",
                            "CRUD operations across all entities"
                        }
                    },
                    new Project
                    {
                        Name = "Personal Portfolio Website",
                        Description = "Modern, responsive portfolio website built with ASP.NET Core MVC showcasing projects and skills",
                        LongDescription = "Developed a professional portfolio website using ASP.NET Core MVC with a modern tech-inspired design. Features include responsive layout with Bootstrap 5, animated UI elements, project showcases with image carousels and embedded videos, interactive skills visualization, and optimized performance. The site demonstrates proficiency in full-stack development, modern web design principles, and user experience optimization.",
                        Technologies = new List<string> { "C#", "ASP.NET Core MVC", "HTML5", "CSS3", "JavaScript", "Bootstrap 5", "Font Awesome", "Responsive Design", "CSS Animations", "Video Integration" },
                        GitHubUrl = "https://github.com/Youssef-Elbarbrawy/Portfolio",
                        LiveUrl = "https://portfolio0-h0babmaxgecrhrew.canadacentral-01.azurewebsites.net/",
                        StartDate = "Dec 2024",
                        EndDate = "Dec 2024",
                        Type = ProjectType.WebApplication,
                        KeyFeatures = new List<string>
                        {
                            "Modern dark tech-themed responsive design",
                            "Interactive animated UI components",
                            "Project galleries with image carousels",
                            "Embedded video demonstrations",
                            "Animated skills progress visualization",
                            "Smooth scrolling navigation",
                            "Mobile-first responsive layout",
                            "Performance optimized loading"
                        }
                    }
                },
                Skills = new List<Skill>
                {
                    // Programming Languages
                    new Skill { Name = "C#", Category = SkillCategory.ProgrammingLanguages, ProficiencyLevel = 5, Icon = "fab fa-microsoft" },
                    new Skill { Name = "Python", Category = SkillCategory.ProgrammingLanguages, ProficiencyLevel = 4, Icon = "fab fa-python" },
                    new Skill { Name = "SQL", Category = SkillCategory.ProgrammingLanguages, ProficiencyLevel = 4, Icon = "fas fa-database" },
                    
                    // Frameworks
                    new Skill { Name = "ASP.NET Core", Category = SkillCategory.Frameworks, ProficiencyLevel = 5, Icon = "fas fa-globe" },
                    new Skill { Name = "Entity Framework (EF Core)", Category = SkillCategory.Frameworks, ProficiencyLevel = 5, Icon = "fas fa-layer-group" },
                    new Skill { Name = "ASP.NET MVC", Category = SkillCategory.Frameworks, ProficiencyLevel = 5, Icon = "fas fa-code" },
                    new Skill { Name = "ASP.NET Web API", Category = SkillCategory.Frameworks, ProficiencyLevel = 5, Icon = "fas fa-exchange-alt" },
                    new Skill { Name = "SignalR", Category = SkillCategory.Frameworks, ProficiencyLevel = 4, Icon = "fas fa-broadcast-tower" },
                    
                    // Tools & Libraries
                    new Skill { Name = "LINQ", Category = SkillCategory.Tools, ProficiencyLevel = 5, Icon = "fas fa-search" },
                    new Skill { Name = "Git", Category = SkillCategory.VersionControl, ProficiencyLevel = 4, Icon = "fab fa-git-alt" },
                    new Skill { Name = "GitHub", Category = SkillCategory.VersionControl, ProficiencyLevel = 4, Icon = "fab fa-github" },
                    new Skill { Name = "Docker", Category = SkillCategory.Tools, ProficiencyLevel = 3, Icon = "fab fa-docker" },
                    new Skill { Name = "AutoMapper", Category = SkillCategory.Tools, ProficiencyLevel = 4, Icon = "fas fa-route" },
                    new Skill { Name = "Swagger/OpenAPI", Category = SkillCategory.Tools, ProficiencyLevel = 4, Icon = "fas fa-file-code" },
                    
                    // Professional Skills
                    new Skill { Name = "Problem-solving", Category = SkillCategory.Professional, ProficiencyLevel = 5, Icon = "fas fa-puzzle-piece" },
                    new Skill { Name = "Team Collaboration", Category = SkillCategory.Professional, ProficiencyLevel = 4, Icon = "fas fa-users" },
                    new Skill { Name = "Time Management", Category = SkillCategory.Professional, ProficiencyLevel = 4, Icon = "fas fa-clock" },
                    new Skill { Name = "Communication", Category = SkillCategory.Professional, ProficiencyLevel = 4, Icon = "fas fa-comments" },
                    new Skill { Name = "Leadership", Category = SkillCategory.Professional, ProficiencyLevel = 4, Icon = "fas fa-crown" },
                    new Skill { Name = "Adaptability", Category = SkillCategory.Professional, ProficiencyLevel = 5, Icon = "fas fa-sync-alt" }
                },
                Education = new Education
                {
                    Degree = "B.S. in Business Information Systems",
                    Institution = "Helwan University",
                    Duration = "Oct 2021 - Jun 2025",
                    Location = "Helwan, EG",
                    GPA = "3.99/4.0"
                },
                Certifications = new List<Certification>
                {
                    new Certification
                    {
                        Name = "ASP.NET Certified Back-End Development",
                        Issuer = "Route Academy",
                        Date = "2024"
                    }
                }
            };
        }
    }
}
