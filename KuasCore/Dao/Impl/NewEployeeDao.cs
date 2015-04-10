using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Impl
{
    class NewEployeeDao:IEmployeeDao
    {
        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee employees1 = new Employee();
            employees1.Id = "yellow";
            employees1.Name = "小黃";
            employees1.Age = 20;
            employees.Add(employees1);

            Employee employees2 = new Employee();
            employees2.Id = "red";
            employees2.Name = "小紅";
            employees2.Age = 10;
            employees.Add(employees2);

            Employee employees3 = new Employee();
            employees3.Id = "white";
            employees3.Name = "小白";
            employees3.Age = 16;
            employees.Add(employees3);
            return employees;

        }
        public Employee GetEmployeeById(string id)
        {
            Employee employees3 = new Employee();
            employees3.Id = "white";
            employees3.Name = "小白";
            employees3.Age = 16;
            return employees3;
        }
    }
}
