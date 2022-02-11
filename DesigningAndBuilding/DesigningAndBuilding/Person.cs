using System;
namespace DesigningAndBuilding
{
    public abstract class Person
    {
        public int age;
        public decimal salary;
        public string address { get; set; }

        public Person()
        {
            
        }

        public int Age(int year)
        {
            int age = DateTime.Now.Year - year;
            return age;
        }

        public virtual decimal Salary()
        {
            return 0;
        }
       

      
    }
}
