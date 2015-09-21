using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SoftwareLearningSystem
{
    public class Trainer: Person
    {
        public Trainer(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine("Course {0} was created.", courseName);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Role: {0}", GetType().Name);

        }
    }
}
