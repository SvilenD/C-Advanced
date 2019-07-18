namespace E04_Froggy
{
    using System.Collections;
    using System.Collections.Generic;

    public class Lake : IEnumerable<int>
    {
        private int[] stones;

        public Lake(int[] input)
        {
            this.stones = input;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Length; i += 2)
            {
                yield return this.stones[i];
            }

            for (int i = this.stones.Length - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return this.stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}