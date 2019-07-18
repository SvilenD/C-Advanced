﻿namespace Demo
{
    using System;
    using System.Collections.Generic;

    public class Cat : IAnimal, IComparable<IAnimal>
    {
        public Cat(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; set; }

        public int Weight { get; set; }

        public string SayHello()
        {
            return "Meow";
        }

        public int CompareTo(IAnimal other)
        {
            var weightDiff = other.Weight - this.Weight; //низходящ ред
            if (weightDiff == 0)
            {
                return this.Name.CompareTo(other.Name); //сравнявам по имена
            }
            return weightDiff;
        }
    }
}
