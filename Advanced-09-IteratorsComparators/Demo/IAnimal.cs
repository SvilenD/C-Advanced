namespace Demo
{
    /// <summary>
    /// Интерфейсите съдържат само публични неща(properties, methods), без логика за изпълнение, 
    /// задължително името започва с I
    /// </summary>
    public interface IAnimal 
    {
        string Name { get; set; }

        string SayHello();
    }
}
