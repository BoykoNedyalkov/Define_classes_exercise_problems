namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Employee : Person
    {
        private double salary;
        private string position;
        private string department;
        private string email;

        public Employee()
        { 
        }

        public Employee(string name, double salary, string position, string department)
            : this()
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
        }

        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public string Email
        {
            get { return this.email = "n/a"; }
            set { this.email = value; }
        }

        //public string CalculateDepartmentWithHighestSalary(Employee[] employees)
        //{
        //}
    }
}
