using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CompanyHierarchy
{
    public class SalesEmployee:Employee
    {
        private Sale sale;

        public SalesEmployee(string id, string firstName, string lastName, double salary, Departments departments, Sale sale) : base(id, firstName, lastName, salary, departments)
        {
            Sale = sale;
        }

        public Sale Sale
        {
            get { return sale; }
            set
            {
                if (value.Equals(null))
                {
                    throw new ArgumentException("The sales cannot be empty");
                }
                sale = value;
            }
        }
    }
}
