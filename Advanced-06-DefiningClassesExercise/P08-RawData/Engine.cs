namespace DefiningClasses
{
    using System;
    public class Engine
    {
        private int speed;
        private int power;
        
        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }
        public int Speed
        {
            get { return this.speed; }

            set
            {
                if (value > 0)
                {
                    this.speed = value;
                }
                else
                {
                    throw new ArgumentException("Engine speed should be positive.");
                }
            }
        }

        public int Power
        {
            get { return this.power; }

            set
            {
                if (value > 0)
                {
                    this.power = value;
                }
                else
                {
                    throw new ArgumentException("Engine power should be positive.");
                }
            }
        }
    }
}