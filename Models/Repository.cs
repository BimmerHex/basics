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
                    Image = "aspnetcore.jpg"
                },
                new Course() {
                    Id = 2,
                    Title = "PHP Kursu",
                    Description = "PHP ile alakalı güzel bir kurs",
                    Image = "php.jpg"
                },
                new Course() {
                    Id = 3,
                    Title = "Django Kursu",
                    Description = "Django ile alakalı güzel bir kurs",
                    Image = "django.jpg"
                },
                new Course() {
                    Id = 4,
                    Title = "Javascript Kursu",
                    Description = "Javascript ile alakalı güzel bir kurs",
                    Image = "javascript.jpg"
                }
            };
        }

        public static List<Course> Courses {
            get {
                return _courses;
            }
        }
    }
}