using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SoftwareLearningSystem
{
    public class OnsiteStuudent: CurrentStudent
    {
        private int numberOfVisits;

        public OnsiteStuudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse, int numberOfVisits) : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits
        {
            get { return numberOfVisits; }
            set {
                if (value < 0)
                {
                    throw new ArgumentException("Visits cannot be negative!");
                }

                numberOfVisits = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\nNumber of visits: {0}", NumberOfVisits);
        }
    }
}
