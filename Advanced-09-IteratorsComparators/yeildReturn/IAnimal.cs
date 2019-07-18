namespace Demo
{
    using System;
    /// <summary>
    /// Интерфейсите съдържат само публични неща(properties, methods), без логика за изпълнение, 
    /// задължително името започва с I
    /// </summary>
    public interface IAnimal :IComparable<IAnimal>
    {
        string Name { get; set; }

        int Weight { get; set; }

        string SayHello();
    }
}