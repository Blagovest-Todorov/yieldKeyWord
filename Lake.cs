using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DemoFrog
{
    class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(List<int> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return stones[i];
                }
            }

            for (int i = stones.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return stones[i]; // yield rememeber the iteration way, and till where it gets, and curr elements value
                }
                //https://stackoverflow.com/questions/39476/what-is-the-yield-keyword-used-for-in-c
            }
            // yield help us to do a custom stateful iteration over a collection
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    } // yiels helps to provid custom itertion without  creating temp collections, yield helps us  to do stateful iteration
    // yield remembers way of iterations and curr element where we are, and el velue, next time we start from point we were , 
    //not from the begginin point
}
