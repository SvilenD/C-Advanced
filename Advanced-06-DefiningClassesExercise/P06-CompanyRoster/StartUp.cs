namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Employee> employeesList = new List<Employee>();

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string position = input[2];
                string department = input[3];
                if (input.Length == 4)
                {
                    Employee employee = new Employee(name, salary, position, department);
                    employeesList.Add(employee);
                }
                else if (input.Length == 5)
                {
                    int age = 0;
                    bool success = int.TryParse(input[4], out age);
                    if (success)
                    {
                        Employee employee = new Employee(name, salary, position, department, age);
                        employeesList.Add(employee);
                    }
                    else
                    {
                        string email = input[4];
                        Employee employee = new Employee(name, salary, position, department, email);
                        employeesList.Add(employee);
                    }
                }
                else if (input.Length == 6)
                {
                    string email = input[4];
                    int age = int.Parse(input[5]);
                    Employee employee = new Employee(name, salary, position, department, email, age);
                    employeesList.Add(employee); 
                }
            }

            var highestAverageSalaryDepartment = employeesList
                .GroupBy(e => e.Department)
                .OrderByDescending(g => g.Select(e => e.Salary).Sum())
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment.Key}");
            Console.WriteLine(string.Join(Environment.NewLine, highestAverageSalaryDepartment
                .OrderByDescending(e => e.Salary)
                .Select(e => $"{e.Name} {e.Salary:F2} {e.Email} {e.Age}")));
        }
    }
}