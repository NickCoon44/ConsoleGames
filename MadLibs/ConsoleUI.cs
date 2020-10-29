using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    public class ConsoleUI
    {
        private bool _isRunning = true;
        public void Start()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            while (_isRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome! Select a Story to MAD LIB.\n" +
                    "1. The Forest\n" +
                    "2. The Cat\n" +
                    "3. The Wizard\n" +
                    "4. The Hole\n" +
                    "5. The Recipe\n" +
                    "6. Nevermind");

                OpenMenuItem();
            }
        }

        private void OpenMenuItem()
        {
            Story story = new Story();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        story.TheForest();
                        return;
                    case "2":
                        story.TheCat();
                        return;
                    case "3":
                        story.TheWizard();
                        return;
                    case "4":
                        story.TheHole();
                        return;
                    case "5":
                        story.TheRecipe();
                        return;
                    case "6":
                        // Nevermind
                        _isRunning = false;
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please pick a valid number.");
                        break;
                }
            }
        }
    }
}
