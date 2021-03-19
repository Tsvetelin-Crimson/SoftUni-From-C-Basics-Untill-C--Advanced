using System;
using System.Collections;
using System.Collections.Generic;

namespace E03CustomMiniStack
{
    class CustomStackMini<T> : IEnumerable<T>
    {
        private List<T> stack;

        public CustomStackMini()
        {
            stack = new List<T>();
        }
        public int Count => stack.Count;


        public void Push(T item)
        {
            stack.Add(item);
        }

        public T Pop()
        {
            T item = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
