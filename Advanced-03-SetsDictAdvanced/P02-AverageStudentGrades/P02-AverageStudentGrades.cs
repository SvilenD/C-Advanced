namespace P02_AverageStudentGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            var marksData = new Dictionary<string, List<double>>();

            for (int i = 0; i < length; i++)
            {
                var studentMarks = Console.ReadLine().Split();

                var name = studentMarks[0];
                var mark = double.Parse(studentMarks[1]);

                if (marksData.ContainsKey(name) == false)
                {
                    marksData.Add(name, new List<double>());
                }
                marksData[name].Add(mark);
            }

            foreach (var student in marksData)
            {
                string name = student.Key;
                var marks = student.Value;
                var average = marks.Average();
                Console.Write($"{name} -> ");
                for (int i = 0; i < marks.Count; i++)
                {
                    Console.Write($"{marks[i]:f2} ");
                }
                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}