using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    public class Room
    {
        public Room(int length, int width, int stairX, int stairY)
        {
            Length = length;
            Width = width;
            StairX = stairX;
            StairY = stairY;
        }
        public int Length { get; set; }
        public int Width { get; set; }
        public int StairX { get; set; }
        public int StairY { get; set; }

        public string ExitProximity(Player player)
        {
            double playerDistance = Math.Sqrt(Math.Pow(Math.Abs(StairX - player.PositionX), 2) + Math.Pow(Math.Abs(StairY - player.PositionY), 2));
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (playerDistance <= Math.Sqrt(2))
            {
                return ("The Exit is right there!");
            }
            else if (playerDistance <= Math.Sqrt(2) * 2)
            {
                return ("You're close to the Exit.");
            }
            else if (playerDistance <= Math.Sqrt(2) * 4)
            {
                return ("You're approaching the Exit.");
            }
            else
            {
                return ("You're nowhere near the Exit.");
            }
        }
    }
}
