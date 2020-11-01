using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    class Program
    {
        static void Main(string[] args)
        {
            FloorOne start = new FloorOne();
            start.Run();

            Console.WriteLine("Press a key to Exit");
            Console.ReadKey();
        }
    }
}
