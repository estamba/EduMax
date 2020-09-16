using System;
using System.Collections.Generic;
using System.Text;

namespace EduMax.Core.Domain
{
    public class Program
    {
        private Program()
        {

        }
        public Program(string code, string name)
        {
            Id = Guid.NewGuid().ToString();
            Code = code;
            Name = name;

        }
        public string Id { get; private set; }
        public string Code { get;  private set; }
        public string Name { get; private set; }
        public string SchoolID { get; private set; }
        public List<Course> Courses { get; private set; }
        public void AddCourse(string name, string code)
        {
            Courses.Add(new Course()
            {
                Code = code,
                Id = Guid.NewGuid().ToString(),
                Name = name
            });
        }
    }
}
