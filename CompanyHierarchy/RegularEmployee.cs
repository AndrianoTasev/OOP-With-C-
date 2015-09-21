using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CompanyHierarchy
{
    public class RegularEmployee : Employee
    {
        public RegularEmployee(string id, string firstName, string lastName, double salary, Departments departments) : base(id, firstName, lastName, salary, departments)
        {
        }
    }
}
