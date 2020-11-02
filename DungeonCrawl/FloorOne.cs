using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    public class FloorOne
    {
        public void Run()
        {
            List<Enemy> enemyList = InitializeEnemies();
            StartGame(enemyList);
        }

        private void StartGame(List<Enemy> enemyList)
        {
            Encounter encounter = new Encounter();
            Player player = new Player(1, 6);
            Room room = new Room(10, 10, 8, 3);
            //FloorTwo floorTwo = new RoomTwo();

            Console.WriteLine("Welcome!\n\n" +
                "Enter a name:");
            player.Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Level One\n" +
                "The smell of iron fills the air...");

            while (!player.GameOver)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(
                    "-Use WASD to move around.\n" +
                    "-Use arrow keys to step by one tile only.\n" +
                    "-Press \"C\" at any time to view your stats.\n" +
                    "-Press \"Q\" at any time to Quit.\n\n\n");
                Console.ResetColor();
                player.Move(room);
                foreach (Enemy enemy in enemyList)
                {
                    enemy.Move(room);
                    if (player.PositionX == enemy.PositionX && player.PositionY == enemy.PositionY)
                    {
                        encounter.EncounterStart(player, enemy);
                    }
                }
                if (player.PositionX == room.StairX && player.PositionY == room.StairY)
                {
                    //floorTwo.Run(player);
                    Console.WriteLine("You did it!");
                    return;
                }
                Console.WriteLine(room.ExitProximity(player));

            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nGAME OVER");
            return;
        }

        private List<Enemy> InitializeEnemies()
        {
            // 10 enemies: 1 boss, 1 hard, 3 medium, 5 easy
            // Level is randomized, and the values are multiplied by Level in the Class
            Random r = new Random();

            Enemy ratOne = new Enemy("Pack of Rats", r.Next(1, 5), 1, 1, 1, 1, 25, 1, 2, 3);
            Enemy ratTwo = new Enemy("Rack of Pats", r.Next(1, 5), 1, 1, 1, 1, 25, 1, 4, 8);
            Enemy banana = new Enemy("Banana Monster", r.Next(1, 5), 2, 1, 2, 2, 50, 10, 4, 4);
            Enemy slime = new Enemy("Living Glue", r.Next(1, 5), 2, 1, 2, 1, 50, 1, 2, 9);
            Enemy rock = new Enemy("Rock...", r.Next(1, 5), 2, 0.2, 0.2, 1, 50, 1, 2, 9);
            Enemy skeleton = new Enemy("Spooky Scary Skeleton", r.Next(1, 5), 3, 0.9, 3, 1, 75, 2, 7, 8);
            Enemy ghost = new Enemy("Invisible Ghost", r.Next(1, 5), 3, 0.8, 4, 1, 75, 4, 6, 2);
            Enemy bat = new Enemy("Bat-shaped Bird", r.Next(1, 5), 4, 0.9, 3, 1, 75, 2, 5, 10);
            Enemy golem = new Enemy("Tall Stone Golem", r.Next(1, 5), 4, 0.8, 4, 1, 125, 3, 8, 6);
            Enemy levelOneBoss = new Enemy("CARL, the Boss", r.Next(1, 5), 5, 0.7, 5, 2, 200, 4, 9, 4);

            return new List<Enemy>() { ratOne, ratTwo, banana, slime, rock, skeleton, ghost, bat, golem, levelOneBoss };
        }
    }
}
