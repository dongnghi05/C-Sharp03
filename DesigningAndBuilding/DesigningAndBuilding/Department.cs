using System;
using System.Collections.Generic;
namespace DesigningAndBuilding
{
    public class Department
    {
        private List<Course> courses;
        public Department()
        {

        }
        public void insertCourse (Course c)
        {
            courses.Add(c);
        }
    }
}
