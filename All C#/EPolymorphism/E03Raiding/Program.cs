using E03Raiding.Core;
using System;

namespace E03Raiding
{
    class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
