using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SoftwareLearningSystem
{
    public class DropOutStudent:CurrentStudent
    {
        private string dropOutReason;

        public DropOutStudent(string firstName, string lastName, int age, int studentNumber,
            double averageGrade, string currentCourse, string dropOutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            DropOutReason = dropOutReason;
        }

        public void Reapply(string message)
        {
            Console.WriteLine("More information about the cuurent student: {0}", message);
        }

        public string DropOutReason
        {
            get { return dropOutReason; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Dropout reason cannot be empty!");
                }

                dropOutReason = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Dropout reason: {0}", DropOutReason);
        }
    }
}
