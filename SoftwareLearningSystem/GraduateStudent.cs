using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SoftwareLearningSystem
{
    public class GraduateStudent : Student
    {
        public GraduateStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade) : base(firstName, lastName, age, studentNumber, averageGrade)
        {
        }
    }
}
