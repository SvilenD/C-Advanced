namespace Tuple
{
    using System.Collections.Generic;

    public class Tuple<T, P>
    {
        public Tuple(T item1, P item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public T Item1 { get; set; }
        public P Item2 { get; set; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}