using Day20_Sabrin.Models;
using Day20_Sabrin.MyDbContext;
using System;

namespace Day20_Sabrin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            using ApplicationDbContext _db = new ApplicationDbContext();

            Employee employee = new Employee(){Employee_Name = "Bader", Employee_Age = 31, Employee_Salary = 6500m};
            _db.Employees.Add(employee);
            _db.SaveChanges();
            
            employee = new Employee() { Employee_Name = "Shaima", Employee_Age = 25, Employee_Salary = 8500 };
            _db.Employees.Add(employee);
            _db.SaveChanges();

            var emp = (from E in _db.Employees 
                      where E.Employee_Id == 3
                      select E).FirstOrDefault();
            Console.WriteLine(emp?.Employee_Name ?? "NA");
            Console.WriteLine(emp?.Employee_Salary ?? 0);

            emp.Employee_Salary = 44500m;    
            _db.Employees.Update(emp);
            _db.SaveChanges();

            Console.WriteLine(emp?.Employee_Salary ?? 0);
        }
    }
}