namespace Demo
{
    using System.Collections.Generic;
    /// <summary>
    /// използва се когато искам да има няколко начина за сравнение и да мога да си избирам в кой случай,
    /// кой от тях да ползвам
    /// </summary>
    public class IAnimalWeightComparer : IComparer<IAnimal>
    {
        public int Compare(IAnimal x, IAnimal y)
        {
            return (x.Weight - y.Weight);
        }
    }
}
