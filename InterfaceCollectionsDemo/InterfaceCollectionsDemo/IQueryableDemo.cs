using System;
using System.Collections.Generic;
using System.Linq;


namespace InterfaceCollectionsDemo
{
    internal class IQueryableDemo
    {
        static  void Main()
        {
            List<Employee> employees = new List<Employee> {
                new Employee{EmpCode=100,EmpName="Scott",Email="scott@gmail.com" },
                new Employee{EmpCode=101,EmpName="Tiger",Email ="tiger@gmail.com"},
                new Employee{EmpCode=102,EmpName="Smith",Email ="smith@gmail.com"},
                new Employee{EmpCode=103,EmpName="Mary",Email ="mary@gmail.com"}

            };

            IQueryable<Employee> selectEmpByEmail = employees.AsQueryable().Where(emp => emp.Email == "tiger@gmail.com");

            IQueryable<Employee> selectByCode = employees.AsQueryable().Where(emp => emp.EmpCode == 101);

            foreach(var employee in selectByCode)
            {
                Console.WriteLine($"Code={employee.EmpCode}\tName={employee.EmpName}\tEmail={employee.Email}");

            }
            Console.ReadLine();
        }
    }
}
