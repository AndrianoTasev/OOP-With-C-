using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CompanyHierarchy
{
    public class Developer: Employee
    {
        private Project project;

        public Developer(string id, string firstName, string lastName, double salary, Departments departments, Project project) : base(id, firstName, lastName, salary, departments)
        {
            Project = project;
        }

        public Project Project { get; set; }
    }
}
