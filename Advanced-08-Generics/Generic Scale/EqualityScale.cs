namespace GenericScale
{
    public class EqualityScale<T>
    {
        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        private T left;
        private T right;

        public bool AreEqual()
        {
            bool result = this.left.Equals(this.right);
            return result;
        }
    }
}