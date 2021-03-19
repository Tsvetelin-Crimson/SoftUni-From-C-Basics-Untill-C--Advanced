using System;
using System.Collections.Generic;
using System.Text;

namespace E03GenericSwapMethodStrings
{
    public class Swapper<T>
    {
        public List<T> List { get; set; }
        //private List<T> list;

        public Swapper()
        {
            List = new List<T>();
        }

        public void Add(T item)
        {
            this.List.Add(item);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T temp = this.List[firstIndex];

            this.List[firstIndex] = this.List[secondIndex];
            this.List[secondIndex] = temp;
        }

        
        //public override string ToString()
        //{
        //    Type t = typeof(T);

        //    foreach (var item in this.list)
        //    {
        //        return $"{t.FullName}: {item}";
        //    }
        //}
    }
}
