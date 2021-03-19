using System;
using System.Collections.Generic;
using System.Linq;

namespace E05GenericCountMethodStringsAndInts
{
    public class Box<T> where T : IComparable
    {
        //private T item;
        private List<T> list;
        public Box()
        {
            //this.item = item;
            this.list = new List<T>();
        }
        
        public List<T> List
        {
            get { return list; }
            private set { list = value; }
        }

        public void AddList(List<T> list)
        {
            this.List = list.ToList();
        }
        public int GetCountOfBiggerItems(T item)
        {
            int count = 0;

            foreach (T currItem in list)
            {
                if (currItem.CompareTo(item) == 1)
                {
                    count++;
                }
            }


            return count;

        }


        //public override string ToString()
        //{
        //    Type t = typeof(T);
        //    T item = this.item;

        //    return $"{t.FullName}: {item}";
        //}


    }
}
