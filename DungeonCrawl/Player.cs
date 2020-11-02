using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    public class Player
    {
        private double _hp = 100;
        private int _healAmount = 15;
        private int _hpLevel = 1;
        private int _hpCap = 100;
        private double _defense = 1;
        private int _defenseLevel = 1;
        private int _strength = 5;
        private int _strengthLevel = 1;
        private int _agility = 1;
        private int _agilityLevel = 1;
        private int _expThreshold = 100;
        private int _totalLevel = 1;
        private bool _runAway = false;
        private bool _gameOver = false;

        public Player(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }

        public string Name { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int SkillPoints { get; set; }
        public int XP { get; set; }

        public double HP
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public int HealAmount
        {
            get { return _healAmount; }
            set { _healAmount = value; }
        }

        public int HPLevel
        {
            get { return _hpLevel; }
            set { _hpLevel = value; }
        }

        public int HPCap
        {
            get { return _hpCap; }
            set { _hpCap = value; }
        }

        public double Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }

        public int DefenseLevel
        {
            get { return _defenseLevel; }
            set { _defenseLevel = value; }
        }

        public int Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }

        public int StrengthLevel
        {
            get { return _strengthLevel; }
            set { _strengthLevel = value; }
        }

        public int Agility
        {
            get { return _agility; }
            set { _agility = value; }
        }

        public int AgilityLevel
        {
            get { return _agilityLevel; }
            set { _agilityLevel = value; }
        }

        public int ExpThreshold
        {
            get { return _expThreshold; }
            set { _expThreshold = value; }
        }

        public int TotalLevel
        {
            get { return _totalLevel; }
            set { _totalLevel = value; }
        }

        public bool RunAway
        {
            get { return _runAway; }
            set { _runAway = value; }
        }

        public bool GameOver
        {
            get { return _gameOver; }
            set { _gameOver = value; }
        }

        public bool LevelUp()
        {
            bool leveledUp = false;
            while (XP > ExpThreshold)
            {

                SkillPoints++;
                ExpThreshold *= 2;
                Console.WriteLine("\nWhat would you like to skill up?\n" +
                    "1. Health\n" +
                    "2. Defense\n" +
                    "3. Strength\n" +
                    "4. Dexterity\n");
                leveledUp = LevelUpSelection();
                TotalLevel++;
                SkillPoints = 0;
            }
            return leveledUp;
        }
        public bool LevelUpSelection()
        {
            while (true)
            {
                var input = Console.ReadKey();
                Console.WriteLine("\n");
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        HPLevel++;
                        HPCap += 20;
                        HealAmount += 4;
                        HP = HPCap;
                        Console.WriteLine($"You leveled up Health. Your HP is now {HP}!");
                        return false;
                    case ConsoleKey.D2:
                        DefenseLevel++;
                        Defense -= .1;
                        HP = HPCap;
                        Console.WriteLine($"You leveled up Defense. Enemies now do x{Defense} damage!");
                        return false;
                    case ConsoleKey.D3:
                        StrengthLevel++;
                        Strength += 5;
                        HP = HPCap;
                        Console.WriteLine($"You leveled up Strength. You now do {Strength} damage!");
                        return false;
                    case ConsoleKey.D4:
                        AgilityLevel++;
                        Agility += 1;
                        HP = HPCap;
                        Console.WriteLine($"You leveled up Agility. You now move {Agility} tiles! (use Arrow keys to step only 1 tile)");
                        return false;
                }
                Console.WriteLine("Invalid input. Try again.");
            }
        }
        public void Move(Room room)
        {
            ConsoleKeyInfo userInput = Console.ReadKey();
            Console.Clear();
            switch (userInput.Key)
            {
                case ConsoleKey.W:
                    PositionY -= Agility;
                    if (PositionY <= 0)
                    {
                        Console.WriteLine("Oof! You ran into the NORTHERN WALL!");
                        PositionY = 1;
                    }
                    else
                    {
                        Console.WriteLine("You move UP");
                    }
                    return;
                case ConsoleKey.D:
                    PositionX += Agility;
                    if (PositionX > room.Length)
                    {
                        Console.WriteLine("Bonk! You ran into the WESTERN WALL!");
                        PositionX = room.Length;
                    }
                    else
                    {
                        Console.WriteLine("You move RIGHT");
                    }
                    return;
                case ConsoleKey.S:
                    PositionY += Agility;
                    if (PositionY > room.Width)
                    {
                        Console.WriteLine("Yeehaw! Y'all ran into the SOUTHERN WALL!");
                        PositionY = room.Width;
                    }
                    else
                    {
                        Console.WriteLine("You move DOWN");
                    }
                    return;
                case ConsoleKey.A:
                    PositionX -= Agility;
                    if (PositionX <= 0)
                    {
                        Console.WriteLine("D'oh! You hit the EASTERN WALL");
                        PositionX = 1;
                    }
                    else
                    {
                        Console.WriteLine("You move LEFT");
                    }
                    return;
                case ConsoleKey.UpArrow:
                    PositionY--;
                    if (PositionY <= 0)
                    {
                        Console.WriteLine("Oof! You ran into the NORTHERN WALL!");
                        PositionY = 1;
                    }
                    else
                    {
                        Console.WriteLine("You step UP 1 tile.");
                    }
                    return;
                case ConsoleKey.RightArrow:
                    PositionX++;
                    if (PositionX > room.Length)
                    {
                        Console.WriteLine("Bonk! You ran into the WESTERN WALL!");
                        PositionX = room.Length;
                    }
                    else
                    {
                        Console.WriteLine("You step RIGHT 1 tile.");
                    }
                    return;
                case ConsoleKey.DownArrow:
                    PositionY++;
                    if (PositionY > room.Width)
                    {
                        Console.WriteLine("Yeehaw! Y'all ran into the SOUTHERN WALL!");
                        PositionY = room.Width;
                    }
                    else
                    {
                        Console.WriteLine("You step DOWN 1 tile.");
                    }
                    return;
                case ConsoleKey.LeftArrow:
                    PositionX--;
                    if (PositionX <= 0)
                    {
                        Console.WriteLine("D'oh! You ran into the EASTERN WALL!");
                        PositionX = 1;
                    }
                    else
                    {
                        Console.WriteLine("You step LEFT 1 tile.");
                    }
                    return;
                case ConsoleKey.C:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("CHARACTER STATS:\n\n" +
                        $"Level: {TotalLevel}\n" +
                        $"HP: {HP}\n" +
                        $"Max Health: {HPCap}\n" +
                        $"Defense: {Defense}\n" +
                        $"Strength: {Strength}\n" +
                        $"Agility: {Agility}\n" +
                        $"XP: {XP}\n");
                    Console.ResetColor();
                    return;
                case ConsoleKey.Q:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Are you sure you want to Quit? Y/N");
                    ConsoleKeyInfo response = Console.ReadKey();
                    switch (response.Key)
                    {
                        case ConsoleKey.Y:
                            GameOver = true;
                            Console.WriteLine("\n");
                            return;
                        case ConsoleKey.N:
                            Console.WriteLine("\n");
                            return;
                    }
                    return;
            }
        }
    }
}
