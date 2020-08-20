using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ike = new Employee();
            ike.firstName = "Ike";
            ike.lastName = "DeRosier";
            ike.yearsOfExperience = 3;

            Employee tike = new Employee();
            tike.firstName = "Tike";
            tike.lastName = "DeRosier";
            tike.yearsOfExperience = 2;

            Employee pike = new Employee();
            pike.firstName = "Pike";
            pike.lastName = "DeRosier";
            pike.yearsOfExperience = 2;

            Employee leader = new Employee();
            leader.firstName = "Josie";
            leader.lastName = "DeRosier";
            leader.yearsOfExperience = 24;

            ike.PrintBio();
            tike.PrintBio();
            pike.PrintBio();
            leader.PrintBio();

            float average = (ike.yearsOfExperience+tike.yearsOfExperience+pike.yearsOfExperience)/3;
            float averageWithLead = ((average * 3) + leader.yearsOfExperience) / 4;

            Console.WriteLine($"\nNot including the leader, the average years of service among employees is {average}.");
            Console.WriteLine($"When you include the leader, the average number of years of service becomes {averageWithLead}.\n");
        }
        
    }
}
