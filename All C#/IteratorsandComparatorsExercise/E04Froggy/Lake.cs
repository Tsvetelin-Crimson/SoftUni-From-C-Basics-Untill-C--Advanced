using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E04Froggy
{
    class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(params int[] stones)
        {
            this.stones = stones.ToList();
        }

        public IEnumerator<int> GetEnumerator()
        {
            int count = stones.Count - 1;

            for (int i = 0; i < stones.Count; i += 2)
            {
                yield return stones[i];
            }

            int lastOddIndex = stones.Count - 1;
            if (lastOddIndex % 2 == 0)
            {
                lastOddIndex--;
            }

            for (int i = lastOddIndex; i >= 0; i-= 2)
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
