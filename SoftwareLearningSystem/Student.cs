using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SoftwareLearningSystem
{
    public class Student: Person
    {
        private int studentNumber;

        private double averageGrade;

        public Student(string firstName, string lastName, int age, int studentNumber, double averageGrade)
            : base(firstName, lastName, age)
        {
            StudentNumber = studentNumber;
            AverageGrade = averageGrade;
        }

        public int StudentNumber
        {
            get { return studentNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Student number cannot be negative or 0!");
                } 

                studentNumber = value;
            }
        }

        public double AverageGrade
        {
            get { return averageGrade; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Average grade cannot be negative or 0!");
                }

                averageGrade = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                   string.Format("\nStudent number: {0} \nAverage grade: {1}",
                   StudentNumber, AverageGrade);
        }
    }
}
