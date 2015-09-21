using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CompanyHierarchy
{
    public class Sale
    {
        private string productName;

        private string productDate;

        private double price;

        public Sale(string productName, string productDate, double price)
        {
            ProductName = productName;
            ProductDate = productDate;
            Price = price;
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The price cannot be negative!");
                }

                price = value;
            }
        }

        public string ProductDate
        {
            get { return productDate; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The product date cannot be negative!");
                }

                productDate = value;
            }
        }

        public string ProductName
        {
            get { return productName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The product name cannot be empty!");
                }

                productName = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                   string.Format("Product name: {0} \nProduct date: {1} \nProduct price: {2}",
                   ProductName,ProductDate, Price);
        }
    }
}
