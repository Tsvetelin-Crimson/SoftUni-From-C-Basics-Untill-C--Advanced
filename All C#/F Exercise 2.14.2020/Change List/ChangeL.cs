using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_List
{
    class ChangeL
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] comArray = command.Split().ToArray();

                if (comArray[0] == "Delete")
                {
                    //RemoveAll(x => x == "kakvo se maha")
                    for (int i = 0; i < list.Count; i++)
                    {
                        list.Remove(int.Parse(comArray[1]));
                    }                    
                }
                else if (comArray[0] == "Insert")
                {
                    list.Insert(int.Parse(comArray[2]), int.Parse(comArray[1]));
                }

            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
