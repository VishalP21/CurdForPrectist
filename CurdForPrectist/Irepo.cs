using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurdForPrectist
{
    public interface Irepo
    {
        bool addemp(Employee employee);

        bool updateemp(Employee employee);

        bool deleteemp(int employeeId);

        public List<Employee> getemployees();
    }
}
