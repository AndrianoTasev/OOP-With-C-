using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SoftwareLearningSystem
{
    public class CurrentStudent:Student
    {
        private string currentCourse;

        public CurrentStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse) : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            CurrentCourse = currentCourse;
        }

        public string CurrentCourse
        {
            get { return currentCourse; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Current course cannot be empty!");
                }

                currentCourse = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\nCurrent course: {0}", CurrentCourse);
        }
    }
}
