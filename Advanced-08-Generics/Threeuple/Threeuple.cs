namespace Threeuple
{

    public class Threeuple<T, P, R> 
    {
        public Threeuple(T item1, P item2, R item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        public T Item1 { get; set; }

        public P Item2 { get; set; }

        public R Item3 { get; set; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }
}
