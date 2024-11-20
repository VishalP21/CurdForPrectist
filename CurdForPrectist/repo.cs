using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurdForPrectist
{
    public class repo : Irepo
    {
        List<Employee> employees;

        public repo()
        {
            employees = new List<Employee>();
        }

        public bool addemp(Employee employee)
        {
            employees.Add(employee);
            return true;
        }

        public bool deleteemp(int employeeId)
        {
            var p = employees.Find(x => x.EmpId == employeeId);
            employees.Remove(p); return true;  
        }

        public List<Employee> getemployees()
        {
          return  employees.ToList();
        }

        public bool updateemp(Employee employee)
        {
            var p = employees.Find(x => x.EmpId == employee.EmpId);
            p.EmpId = employee.EmpId;
            p.FirstName = employee.FirstName;
            p.LastName = employee.LastName;
            return true;
        }
    }
}
