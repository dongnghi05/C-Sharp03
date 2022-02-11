using System;
using System.Collections.Generic;
namespace DesigningAndBuilding
{
    public class Student : Person
    {
        public Dictionary<Course, string> course;
        
        public Student()
        {
            
        }
      

        public void addCourse(Course c, string grade)
        {
            course.Add(c, grade);
        }

    }
}
