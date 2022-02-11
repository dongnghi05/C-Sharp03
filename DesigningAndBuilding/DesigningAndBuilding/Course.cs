using System;
using System.Collections.Generic;
namespace DesigningAndBuilding
{
    public class Course
    {
        public List<Student> students;
        public Course()
        {

        }
        public void InsertStudent(Student student)
        {
            students.Add(student);
        }

    }
}
