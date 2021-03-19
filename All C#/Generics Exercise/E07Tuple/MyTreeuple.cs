using System;
using System.Collections.Generic;
using System.Text;

namespace E07Tuple
{
    class MyTreeuple<T, V, U>
    {
        public T FirstItem { get; private set; }

        public V SecondItem { get; private set; }

        public U ThirdItem { get; private set; }
        public MyTreeuple(T firstItem, V secondItem, U thirdItem)
        {
            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
            this.ThirdItem = thirdItem;
        }

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem} -> {ThirdItem}";
        }
    }
}
