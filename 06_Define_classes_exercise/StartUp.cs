namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var numberOfEmployees = int.Parse(Console.ReadLine());

            Employee[] employees = new Employee[numberOfEmployees];

            for (int i = 0; i < numberOfEmployees; i++)
            {
                var employeeData = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                var name = employeeData[0];
                var salary = double.Parse(employeeData[1]);
                var position = employeeData[2];
                var department = employeeData[3];
                var email = employeeData[4];
                var age = int.Parse(employeeData[5]);

                Employee employee = new Employee
                {
                    Name = name,
                    Salary = salary,
                    Position = position,
                    Department = department,
                    Email = email,
                    Age = age
                };

                employees[i] = employee;
            }
        }

    }
}
