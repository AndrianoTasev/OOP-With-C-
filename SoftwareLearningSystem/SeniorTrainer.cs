using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SoftwareLearningSystem
{
    public class SeniorTrainer: Person
    {
        public SeniorTrainer(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }

        public void DeleteCourse(string deleteCourse)
        {
            Console.WriteLine("The {0} course was deleted.", deleteCourse);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Role: {0}", GetType().Name);
        }
    }
}
