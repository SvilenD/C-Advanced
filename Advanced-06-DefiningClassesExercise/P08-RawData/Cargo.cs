namespace DefiningClasses
{
    using System;
    public class Cargo
    {
        private int weight;
        private string type;

        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }

        public int Weight
        {
            get { return this.weight; }

            set
            {
                if (value > 0)
                {
                    this.weight = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Cargo Weight value.");
                }
            }
        }

        public string Type
        {
            get { return this.type; }

            set { if (value != null) this.type = value; }
        }
    }
}