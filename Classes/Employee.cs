using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Employee
    {
        public string firstName;
        public string lastName;
        public int yearsOfExperience;

        public void PrintBio() {
            Console.WriteLine($"{firstName} {lastName}, {yearsOfExperience} years of experience.");
        }
    }
}
