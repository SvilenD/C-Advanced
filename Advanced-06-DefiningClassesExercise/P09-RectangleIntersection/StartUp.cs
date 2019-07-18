namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var rectangles = new List<Rectangle>();

            int[] count = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int rectanglesCount = count[0];
            for (int i = 0; i < rectanglesCount; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var id = input[0];
                double width = double.Parse(input[1]);
                double height = double.Parse(input[2]);
                double x = double.Parse(input[3]);
                double y = double.Parse(input[4]);

                var rectangle = new Rectangle(id, width, height, x, y);
                rectangles.Add(rectangle);
            }

            int intersectionsCount = count[1];
            for (int i = 0; i < intersectionsCount; i++)
            {
                var tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var firstRectangle = rectangles.Find(r => r.Id == tokens[0]);
                var secondRectangle = rectangles.Find(r => r.Id == tokens[1]);

                Console.WriteLine(firstRectangle.CheckIntersection(secondRectangle));
            }
        }
    }
}