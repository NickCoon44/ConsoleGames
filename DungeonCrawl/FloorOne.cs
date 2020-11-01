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
                    "-Press \"M\" at any time to view your stats.\n" +
                    "-Press \"Q\" at any time to quit.\n\n\n");
                Console.ForegroundColor = ConsoleColor.White;
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
            // 10 enemies: 1 boss, 2 hard, 3 medium, 4 easy
            Enemy ratOne = new Enemy("Pack of Rats", 1, 5, 1, 3, 2, 50, 1, 2, 3);
            Enemy ratTwo = new Enemy("Rack of Pats", 1, 5, 1, 3, 2, 50, 1, 4, 8);
            Enemy banana = new Enemy("Banana Monster", 1, 7, 1, 5, 2, 75, 1, 4, 4);
            Enemy slime = new Enemy("Living Glue", 1, 7, 1, 5, 1, 75, 1, 2, 9);
            Enemy skeleton = new Enemy("Spooky Scary Skeleton", 2, 12, 0.9, 8, 1, 125, 2, 7, 8);
            Enemy ghost = new Enemy("Invisible Ghost", 2, 13, 0.8, 7, 1, 125, 4, 6, 2);
            Enemy bat = new Enemy("Bat-shaped Bird", 2, 12, 0.9, 8, 1, 125, 2, 5, 10);
            Enemy golemOne = new Enemy("Tall Stone Golem", 3, 17, 0.8, 13, 2, 175, 3, 8, 6);
            Enemy golemTwo = new Enemy("Wide Stone Golem", 3, 17, 0.8, 13, 2, 175, 3, 10, 2);
            Enemy levelOneBoss = new Enemy("CARL, the Boss of deadly doom and stuff", 5, 25, 0.7, 20, 1, 250, 4, 9, 4);

            return new List<Enemy>() { ratOne, ratTwo, banana, slime, skeleton, ghost, bat, golemOne, golemTwo, levelOneBoss };
        }
    }
}
