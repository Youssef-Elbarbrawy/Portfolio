namespace Portfolio.Models
{
    public class PortfolioViewModel
    {
        public PersonalInfo PersonalInfo { get; set; } = new();
        public List<Project> Projects { get; set; } = new();
        public List<Skill> Skills { get; set; } = new();
        public List<Experience> Experiences { get; set; } = new();
        public Education Education { get; set; } = new();
        public List<Certification> Certifications { get; set; } = new();
    }

    public class PersonalInfo
    {
        public string Name { get; set; } = "Youssef Mohammad";
        public string Title { get; set; } = ".NET Back-End Developer";
        public string Location { get; set; } = "Cairo, Egypt";
        public string Email { get; set; } = "youssefmohammad000@gmail.com";
        public string LinkedIn { get; set; } = "www.linkedin.com/in/youssef-mohammad10";
        public string GitHub { get; set; } = "github.com/MrBarbrawy";
        public string Phone { get; set; } = "+201011222194";
        public string Summary { get; set; } = "Recent Business Information Systems graduate from Helwan University specializing in .NET development and back-end solutions. Experienced in solving complex problems and delivering efficient software applications through hands-on project experience. Proficiency in ASP.NET Core, C#, Entity Framework, and SQL enables effective delivery across Software Development Lifecycle from requirements analysis to deployment.";
        public string ProfileImagePath { get; set; } = "/images/profile/youssef-profile.jpg";
    }

    public class Project
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string LongDescription { get; set; } = string.Empty;
        public List<string> Technologies { get; set; } = new();
        public string GitHubUrl { get; set; } = string.Empty;
        public string LiveUrl { get; set; } = string.Empty;
        public string VideoUrl { get; set; } = string.Empty;
        public List<string> ImagePaths { get; set; } = new();
        public string StartDate { get; set; } = string.Empty;
        public string EndDate { get; set; } = string.Empty;
        public ProjectType Type { get; set; }
        public List<string> KeyFeatures { get; set; } = new();
    }

    public enum ProjectType
    {
        WebApplication,
        API,
        FullStack,
        MobileApp
    }

    public class Skill
    {
        public string Name { get; set; } = string.Empty;
        public SkillCategory Category { get; set; }
        public int ProficiencyLevel { get; set; } // 1-5
        public string Icon { get; set; } = string.Empty;
    }

    public enum SkillCategory
    {
        ProgrammingLanguages,
        Frameworks,
        Databases,
        Tools,
        VersionControl,
        Professional
    }

    public class Experience
    {
        public string Position { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Achievements { get; set; } = new();
    }

    public class Education
    {
        public string Degree { get; set; } = "B.S. in Business Information Systems";
        public string Institution { get; set; } = "Helwan University";
        public string Duration { get; set; } = "Oct 2021 - Jun 2025";
        public string Location { get; set; } = "Helwan, EG";
        public string GPA { get; set; } = "3.99/4.0";
    }

    public class Certification
    {
        public string Name { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
    }
}
