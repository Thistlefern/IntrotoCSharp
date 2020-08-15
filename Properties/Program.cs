using System;

namespace Properties
{
    public class Employee
    {
        public static int NumberOfEmployees;
        private static int _counter;
        private string _name;

        // A read-write instance property:
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        // A read-only static property:
        public static int Counter => _counter;

        // A Constructor:
        public Employee() => _counter = ++NumberOfEmployees; // Calculate the employee's number:
    }

    class TestEmployee
    {
        static void Main()
        {
            Employee.NumberOfEmployees = 107;
            Employee e1 = new Employee();
            e1.Name = "Claude Vige";

            System.Console.WriteLine("Employee number: {0}", Employee.Counter);
            System.Console.WriteLine("Employee name: {0}", e1.Name);
        }
    }
    /* Output:
        Employee number: 108
        Employee name: Claude Vige
    */
}
