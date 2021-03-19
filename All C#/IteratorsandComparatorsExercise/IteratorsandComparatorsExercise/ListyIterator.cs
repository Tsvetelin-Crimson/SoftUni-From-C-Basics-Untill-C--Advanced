using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsandComparatorsExercise
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> items;
        private int index;
        //private T currItem;

        public ListyIterator(List<T> collection)
        {
            this.items = collection;
            this.index = 0;
            //this.currItem = items[index];
        }

        public bool Move()
        {
            bool hasMoved = true;

            if (index == items.Count - 1)
            {
                hasMoved = false;
            }
            else
            {
                this.index++;
                //this.currItem = items[index];
            }
            return hasMoved;
        }

        public bool HasNext() //could use this in Move()
        {
            bool hasNext = true;
            if (index == items.Count - 1)
                hasNext = false;

            return hasNext;
        }

        public void Print()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.items[this.index]);
        }
        
        public void PrintAll()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            foreach (var item in items)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < items.Count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
