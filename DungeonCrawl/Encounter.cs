using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    public class Encounter
    {
        public void EncounterStart(Player player, Enemy enemy)
        {
            Console.Clear();
            Console.WriteLine($"You've encountered a {enemy.Name}!");
            Moves(player, enemy);
            if (player.HP <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You were killed by {enemy.Name}.");
                player.GameOver = true;
                return;
            }
            else if (player.RunAway == true)
            {
                Console.WriteLine("You escaped.");
                player.RunAway = false;
                return;
            }
            else
            {
                player.XP += enemy.XPGiven;
                enemy.PositionX = 0;
                enemy.PositionY = 0;
                enemy.Dead = true;
                Console.WriteLine($"You beat {enemy.Name}. You gained {enemy.XPGiven} experience points!");
                player.LevelUp();
                return;
            }
        }

        public void Moves(Player player, Enemy enemy)
        {
            while (true)
            {
                if (player.HP <= 0 || enemy.HP <= 0)
                {
                    return;
                }
                else
                {
                    PlayerMove(player, enemy);
                    if (player.RunAway == true)
                    {
                        return;
                    }
                    EnemyMove(player, enemy);
                }
            }
        }

        public void PlayerMove(Player player, Enemy enemy)
        {
            Console.WriteLine($"{player.Name} HP: {player.HP}\n" +
                $"{enemy.Name}: Level {enemy.Level}\n\n" +
                $"What do you do?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(
                "1. Attack\n" +
                "2. Heal\n" +
                "3. Run Away\n");
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                Console.WriteLine();
                switch (userInput.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        double damageDone = (player.Strength * enemy.Defense);
                        enemy.HP -= damageDone;
                        Console.WriteLine($"You did {damageDone} damage!");
                        return;
                    case ConsoleKey.D2:
                        Console.Clear();
                        if (player.HP < (player.HPCap - player.HealAmount))
                        {
                            player.HP += player.HealAmount;
                            Console.WriteLine($"You restored {player.HealAmount} health.");
                        }
                        else
                        {
                            double amountHealed = player.HPCap - player.HP;
                            player.HP = player.HPCap;
                            Console.WriteLine($"You restored {amountHealed} health.");
                        }
                        return;
                    case ConsoleKey.D3:
                        Console.Clear();
                        if (player.Agility >= enemy.FleeThreshold)
                        {
                            player.RunAway = true;
                        }
                        else
                        {
                            Console.WriteLine("You were not Agile enough to escape.");
                        }
                        return;
                }
                Console.WriteLine("Invalid input. Try again.");
            }
        }

        public void EnemyMove(Player player, Enemy enemy)
        {
            double damageDone = enemy.Strength * player.Defense;
            player.HP -= damageDone;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{enemy.Name} attacked you! {damageDone} health lost!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
