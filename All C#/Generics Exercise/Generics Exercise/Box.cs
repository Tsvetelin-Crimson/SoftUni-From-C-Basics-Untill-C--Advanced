using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Exercise
{
    public class Box<T> 
    {
        private T box;

        public Box(T item)
        {
            this.box = item;
        }

        public override string ToString()
        {
            Type t = typeof(T);
            T item = this.box;

            return $"{t.FullName}: {item}";
        }


    }
}
