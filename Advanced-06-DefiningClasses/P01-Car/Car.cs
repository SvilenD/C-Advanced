namespace CarManufacturer
{
    using System;

    public class Car
    {
        private string make;
        private string model;
        private int year;

        public string Make
        {
            get
            {
                return this.make;
            }

            set
            {
                if (value.Length > 0)
                {
                    this.make = value;
                }
            }
        }

        public string Model // {get; set;}//
        {
            get
            {
                return this.model;
            }

            set
            {
                if (value.Length > 0)
                {
                    this.model = value;
                }
            }
        }

        public int Year
        {
            get
            {
                return this.year;
            }

            set
            {
                if (value > 0)
                {
                    this.year = value;
                }
            }
        }
    }
}