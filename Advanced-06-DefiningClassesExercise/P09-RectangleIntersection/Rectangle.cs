namespace DefiningClasses
{
    using System;
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double topLeftX;
        private double topLeftY;

        public Rectangle(string id, double width, double height, double topLeftX, double topLeftY)
        {
            this.id = id;
            this.width = Math.Abs(width);
            this.height = Math.Abs(height);
            this.topLeftX = topLeftX;
            this.topLeftY = topLeftY;
        }

        public string Id
        {
            get { return this.id; }

            set
            {
                if (id.Length > 0)
                {
                    this.id = value;
                }
            }
        }

        public string CheckIntersection(Rectangle rectangle)
        {
            if (rectangle.topLeftX + rectangle.width >= this.topLeftX &&
               rectangle.topLeftX <= this.topLeftX + this.width &&
               rectangle.topLeftY >= this.topLeftY - this.height &&
               rectangle.topLeftY - rectangle.height <= this.topLeftY)
            {
                return "true ";
            }
            else return "false";
        }
    }
}