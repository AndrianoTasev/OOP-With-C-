using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CompanyHierarchy
{
    public class Person
    {
        private string id;

        private string firstName;

        private string lastName;

        public Person(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The last name cannot be empty!");
                }

                lastName = value;
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The first name cannot be empty!");
                }

                firstName = value;
            }
        }

        public string Id
        {
            get { return id; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The id cannot be empty!");
                }

                id = value;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            output.AppendFormat("Persons information. {0}", Environment.NewLine);

            output.AppendFormat("Persons ID: {0}.{1}", this.Id, Environment.NewLine);

            output.AppendFormat("First name: {0}.{1}", this.FirstName, Environment.NewLine);

            output.AppendFormat("Last name: {0}.{1}", this.LastName, Environment.NewLine);

            return output.ToString();
        }
    }
}
