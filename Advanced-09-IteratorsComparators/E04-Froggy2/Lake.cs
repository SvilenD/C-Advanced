namespace Froggy2
{
    using System.Collections;
    using System.Collections.Generic;

    public class Lake : IEnumerable<int>
    {
        private int[] stones;

        public Lake(params int[] stoneValues)
        {
            this.stones = stoneValues;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Length; i += 2)
            {
                yield return stones[i];
            }

            int startReversedIndex = this.stones.Length % 2 == 0
                ? this.stones.Length - 1
                : this.stones.Length - 2;
                
            for (int i = startReversedIndex; i >= 0; i -= 2)
            {
                yield return stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}