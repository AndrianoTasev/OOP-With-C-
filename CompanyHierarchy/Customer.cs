using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CompanyHierarchy
{
    public class Customer : Person
    {
        private double tatalMoneySpent;

        public Customer(string id, string firstName, string lastName, double totalMoneySpent) : base(id, firstName, lastName)
        {
            TotalMoneySpent = totalMoneySpent;
        }

        public double TotalMoneySpent { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format("Total money spent: {0}", TotalMoneySpent);
        }
    }
}
