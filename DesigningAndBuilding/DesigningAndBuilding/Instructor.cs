using System;
namespace DesigningAndBuilding
{
    public class Instructor : Person
    {
        public DateTime JoinDate { get; set; }
        public Instructor(decimal s)
        {
            salary = s;
        }
        public override decimal Salary()
        {
            int year = DateTime.Now.Year - JoinDate.Year;
            if (year < 2) return salary;
            else if (year < 5) return salary * 120/100;
            else return salary * 2;
        }
    }
}
