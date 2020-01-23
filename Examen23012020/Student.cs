using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen23012020
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal ClassNumber { get; set; }

        public Student(string firstName, string lastName, decimal classNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            ClassNumber = classNumber;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}