namespace ResumeWebsite.Models
{
    public class ResumeViewModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }

        public string Education10th { get; set; }
        public string Education12th { get; set; }

        public string Experience { get; set; }

        public List<string> Frameworks { get; set; }
        public List<string> Languages { get; set; }
        public List<string> Databases { get; set; }
        public List<string> Platforms { get; set; }

        public List<ProjectModel> Projects { get; set; }
    }
    public class ProjectModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string GithubUrl { get; set; }
    }
}
