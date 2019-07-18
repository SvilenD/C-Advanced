namespace P01_Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var doctorPatients = new Dictionary<string, List<string>>();
            var departmentPatients = new Dictionary<string, List<string>>();

            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Output")
            {
                string department = input[0];
                string doctor = input[1] + " " + input[2];
                string patient = input[3];

                if (departmentPatients.ContainsKey(department) == false)
                {
                    departmentPatients.Add(department, new List<string>());
                }
                if (doctorPatients.ContainsKey(doctor) == false)
                {
                    doctorPatients.Add(doctor, new List<string>());
                }
                if (departmentPatients[department].Count >= 60)
                {
                    continue;
                }

                departmentPatients[department].Add(patient);
                doctorPatients[doctor].Add(patient);

                input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "End")
            {
                if (command.Length == 1)
                {
                    var dep = departmentPatients.FirstOrDefault(d => d.Key == command[0]);
                    Console.WriteLine($"{string.Join(Environment.NewLine, dep.Value)}");
                    continue;
                }

                int number;
                bool success = Int32.TryParse(command[1], out number);
                if (success)
                {
                    number -= 1;
                    var dep = departmentPatients.FirstOrDefault(d => d.Key == command[0]);
                    Console.WriteLine(string.Join(Environment.NewLine, dep.Value
                        .Skip(3 * number)
                        .Take(3)
                        .OrderBy(p => p)));
                }
                else
                {
                    var doctor = command[0] + " " + command[1];

                    Console.WriteLine($"{string.Join(Environment.NewLine, doctorPatients[doctor].OrderBy(p => p))}");
                }

                command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}