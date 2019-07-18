namespace CarManufacturer
{
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

        public int HorsePower
        {
            get
            {
                return this.horsePower;
            }

            set
            {
                if (value >= 0)
                {
                    this.horsePower = value;
                }
            }
        }

        public double CubicCapacity
        {
            get
            {
                return this.cubicCapacity;
            }

            set
            {
                if (value >= 0)
                {
                    this.cubicCapacity = value;
                }
            }
        }
    }
}