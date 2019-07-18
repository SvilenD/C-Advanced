namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        private T item;

        public Box(T value)
        {
            this.item = value;
        }

        public override string ToString()
        {
            return $"{item.GetType()}: {item}";
        }
    }
}
