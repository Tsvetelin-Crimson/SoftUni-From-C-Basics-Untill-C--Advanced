using Generics_Exercise;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace GenericBox
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
                Console.WriteLine(box.ToString());
            }


            //Box<string> box = new Box<string>("adwadawdawd");



        }
    }
}
