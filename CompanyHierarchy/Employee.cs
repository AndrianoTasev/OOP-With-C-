using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CompanyHierarchy
{
    public class Employee : Person
    {
        private double salary;

        private Departments department;

        public Employee(string id, string firstName, string lastName, double salary, Departments departments)
            : base(id, firstName, lastName)
        {
            Salary = salary;
            Department = departments;
        }

        public Departments Department
        {
            get { return department; }
            set
            {
                department = value;
            }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value <= 0 )
                {
                    throw new ArgumentException("The salary cannot be negative or 0!");
                }

                salary = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Salary: {0} \nDepartment: {1}", this.Salary, this.Department);
        }
    }
}
