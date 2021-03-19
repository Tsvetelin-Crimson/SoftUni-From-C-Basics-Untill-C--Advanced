using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upr4
{
    class OldLibrary
    {
        static void Main(string[] args)
        {
            string bookForSearch = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            int checkedBooks = 0;

            while (capacity > checkedBooks)
            {
                string bookChecked = Console.ReadLine();

                if(bookChecked == bookForSearch)
                {
                    break;
                }
                else
                {
                    checkedBooks++;
                }
            }

            if (capacity != checkedBooks)
            {
                Console.WriteLine($"You checked {checkedBooks} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
            }

        }
    }
}
