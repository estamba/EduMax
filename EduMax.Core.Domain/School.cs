using System;
using System.Collections.Generic;
using System.Text;

namespace EduMax.Core.Domain
{
    public class School
    {
        private School()
        {

        }
        public School(string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
           
        }
        public string Id { get; private set; }
        public string Name { get; set; }
        public  List<Campus> Campuses { get; private set; }

        public void AddCampus(string campusName)
        {
            Campuses.Add(new Campus()
            {
                Id = Guid.NewGuid().ToString(),
                Name = campusName
            });
        }
    }

}
