using System;
using System.Collections.Generic;
using System.Text;

namespace EduMax.Core.Domain
{
    public class Course
    {
        public string Id { get; set; }
        public string  Name { get; set; }
        public string  Code { get; set; }
        public CourseStatus Status { get; set; }
    }
}
