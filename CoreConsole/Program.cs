using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = null;
            string str = obj?.FirstName;
            Console.WriteLine(str);
            List<Employee> lstEmp = lstEmp = new List<Employee>();
            lstEmp.Add(new Employee() { FirstName = "Narender", EmpId = 1, Salary = 10 });
            lstEmp.Add(new Employee() { FirstName = "Narender", EmpId = 1, Salary = 20 });
            lstEmp.Add(new Employee() { FirstName = "Gandi", EmpId = 2, Salary = 20 });
            lstEmp.Add(new Employee() { FirstName = "Gandi", EmpId = 2, Salary = 20 });
            var test = lstEmp.GroupBy(x => x.EmpId).Select(
                       g => new
                       {
                           FirstName = g.First().FirstName,
                           EmpId = g.First().EmpId,
                           Salary = g.Sum(s => s.Salary)
                       }).ToList();
            lstEmp = lstEmp.GroupBy(x => x.EmpId).Select(g => new Employee() { EmpId = g.First().EmpId, FirstName = g.First().FirstName, Salary = g.Sum(s => s.Salary) }).ToList();
            //test the repository
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public int EmpId { get; set; }
        public int Salary { get; set; }
    }
}
