namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository() {
            _courses = new List<Course>() {
                new Course() {
                    Id = 1,
                    Title = "ASPNET Core Kursu",
                    Description = "ASPNET Core ile alakalı güzel bir kurs",
                    Image = "aspnetcore.jpg",
                    Tags = new string[] { "aspnet", "web geliştirme" },
                    isActive = true,
                    isHome = false
                },
                new Course() {
                    Id = 2,
                    Title = "PHP Kursu",
                    Description = "PHP ile alakalı güzel bir kurs",
                    Image = "php.jpg",
                    Tags = new string[] { "php", "web geliştirme" },
                    isActive = true,
                    isHome = true
                },
                new Course() {
                    Id = 3,
                    Title = "Django Kursu",
                    Description = "Django ile alakalı güzel bir kurs",
                    Image = "django.jpg",
                    isActive = true,
                    isHome = true
                },
                new Course() {
                    Id = 4,
                    Title = "Javascript Kursu",
                    Description = "Javascript ile alakalı güzel bir kurs",
                    Image = "javascript.jpg",
                    Tags = new string[] { "javascript", "web geliştirme" },
                    isActive = true,
                    isHome = true
                }
            };
        }

        public static List<Course> Courses {
            get {
                return _courses;
            }
        }

        public static Course? GetById(int? id) {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}