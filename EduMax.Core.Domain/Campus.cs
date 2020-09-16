using System;
using System.Collections.Generic;
using System.Text;

namespace EduMax.Core.Domain
{
    public class Campus
    {
        public string Id { get; set; }
        public School School { get; set; }
        public string Name { get; set; }
    }
}
