using Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    
    class Team
    {

        public Employee[] employeeList = new Employee[5];

        public void averageExperience()
        {
            float totalYears = 0;
            int employeeCount = 0;

            foreach (Employee cMember in employeeList)
            {
                if (cMember != null)
                {
                    totalYears += cMember.yearsOfExperience;
                    employeeCount++;
                }
            }
            Console.WriteLine($"The average experience among employees is {totalYears / employeeCount} years.");

        }


    }
}