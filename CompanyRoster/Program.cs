namespace CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int employeeCount = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < employeeCount; i++)
            {
                string[] employeeArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = employeeArgs[0];
                double salary = double.Parse(employeeArgs[1]);
                string position = employeeArgs[2];
                string deparment = employeeArgs[3];

                Employee employee = null;

                if (employeeArgs.Length == 4)
                {
                    employee = new Employee(name, salary, position, deparment);
                }
                else if (employeeArgs.Length == 6)
                {
                    string email = employeeArgs[4];
                    int age = int.Parse(employeeArgs[5]);

                    employee = new Employee(name, salary, position, deparment, email, age);
                }
                else
                {
                    int age = 0;

                    bool isAge = int.TryParse(employeeArgs[4], out age );

                    if (isAge)
                    {
                        employee = new Employee(name, salary, position, deparment, age);
                    }
                    else
                    {
                        employee = new Employee(name, salary, position, deparment, employeeArgs[4]);
                    }
                }

                employees.Add(employee);
            }

            Dictionary<string, List<Employee>> groupsByDepartment = employees.GroupBy(e => e.Department).ToDictionary(g => g.Key, g1 => g1.ToList());

            foreach (var kvp in groupsByDepartment)
            {
                var department = kvp.Key;
                var allEmployees = kvp.Value;
                
                foreach (var item in allEmployees)
                {
                    Console.WriteLine($"{department} + {item.Name}");
                }
            }
        }
    }
}
