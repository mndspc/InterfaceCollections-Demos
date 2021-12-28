using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1=new Employee { EmpCode = 100, EmpName = "Scott", Email = "scott@gmail.com" };
            Employee employee2 = new Employee { EmpCode = 101, EmpName = "Tiger", Email = "tiger@gmail.com" };
            Employee employee3 = new Employee { EmpCode = 103, EmpName = "Smith", Email = "smith@gmail.com" };

            //  To Create Quickly disposable object
            using (Employees employees = new Employees())
            {
                employees[0] = employee1;
                employees[1] = employee2;
                employees[2] = employee3;

                foreach (var emp in employees)
                {
                    Console.WriteLine($"Code={emp.EmpCode}\tName={emp.EmpName}\tEmail={emp.Email}");
                }
            }
            
          

            Console.ReadLine();
        }
    }
}
