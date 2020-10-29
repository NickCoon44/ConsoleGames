using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    public class Story
    {
        public string Capitalize(string input)
        {
            return input.Substring(0, 1).ToUpper() + input.Substring(1).ToLower();
        }
        public void TheForest()
        {
            Console.Clear();
            string[] prompts = { "Type a Name: ", "Type an Adjective that Describes You: ", "Type a Verb: ", "Type an Adverb: ", "Type a Plural Noun: ", "Type an Adjective: ", "Type an Animal: ", "Type a Word You Made Up! (Noun): ", "Type a Verb (Past Tense): ", "Type a Color: ", "Type a Body Part (plural): ", "Type an Adjective: ", "Type in a Piece of Advice You'd Like to Share: " };
            string[] input = new string[13];

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(prompts[i]);
                input[i] = Console.ReadLine();
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" There once was a boy in The Forest named {Capitalize(input[0])}. {Capitalize(input[0])} was very {input[1]}.\n" +
                $" One day, while he was searching for {input[4]}, he heard a noise from deep in the Forest.\n" +
                $" It sounded like some kind of {input[11]} {input[6]}. {Capitalize(input[0])} stood up {input[3]} and looked around.\n" +
                $" Suddenly a great creature bounded out of the bushes. \"Ahh! The {Capitalize(input[7])}!\" he shouted.\n" +
                $" The {Capitalize(input[7])} was {input[5]}. It had glowing {input[9]} eyes and grotesque {input[10]}.\n" +
                $" {Capitalize(input[0])} tried to {input[2]}, but before he could, the {Capitalize(input[7])} {input[8]}. \n" +
                $" This surprised the boy, as he was not expecting that. \n" +
                $" Luckily, {Capitalize(input[0])} got home safely that night. Somehow.\n" +
                $" He learned a valuable lesson that day: {Capitalize(input[12])}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }

        public void TheCat() //Written by Peyton Cooper
        {
            Console.Clear();
            string[] prompts = { "Type a Name: ", "Type an Adjective: ", "Type a Noun: ", "Type a Noun: ", "Type a Noun: ", "Type an Adjective: ", "Type a Verb: ", "Type an Adverb: ", "Type a Verb (Past Tense): ", "Type an Adjective: ", "Type a Verb (Past Tense): " };

            string[] input = new string[11];
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(prompts[i]);
                input[i] = Console.ReadLine();
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" A cat named {Capitalize(input[0])} was as {input[1]} as a {input[2]}. {Capitalize(input[0])} the cat was hungry and wanted\n" +
                $" to eat a bowl of {input[3]} and drink some {input[4]}. When {Capitalize(input[0])} was done eating, his {input[5]}\n" +
                $" owners arrived home and told him it was time to go {input[6]}. {input[0]} was not happy about this and {input[7]} {input[8]} away.\n" +
                $" When the {input[9]} owners found him, {Capitalize(input[0])} {input[10]} on them and began to scratch. Now {Capitalize(input[0])} the cat does\n" +
                $" whatever he pleases all day long.");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }

        public void TheWizard()
        {
            Console.Clear();
            string[] prompts = { "Type an Adjective: ", "Type a Body Part: ", "Type a Plural Noun: ", "Type a Verb: ", "Type a Number: ", "Type a Plural Noun: ", "Type an Object: ", "Make up a Phrase!: ", "Type a Sound Effect!: ", "Name a Place: " };
            string[] input = new string[10];

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(prompts[i]);
                input[i] = Console.ReadLine();
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" You are a mighty Wizard!\n" +
                $" With just a wave of your {input[1]}, you can cast {input[0]} Magic!\n" +
                $" When angry, you can shoot projectile {input[2]} from your trustworthy, magical {input[6]}!\n" +
                $" When frightened, you can shout your Incantation, \"{input[7]}!\" and your problems disappear!\n" +
                $" When you wish to travel to {input[9]}, you can simply {input[3]} your fingers and {input[8]}! You're there!\n" +
                $" And you have at least {input[4]} more Spells at your disposal!\n" +
                $" You would be unstoppable, if it weren't for your one weakness: {input[5]}.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }

        public void TheHole() // Written by Peyton Cooper
        {
            Console.Clear();
            string[] prompts = { "Type an Adjective: ", "Type an Adjective: ", "Type a Noun: ", "Type a Verb (Past Tense): ", "Type a Verb (Past Tense): " };

            string[] input = new string[5];
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(prompts[i]);
                input[i] = Console.ReadLine();
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" One day, a little girl, who loved to play outside, found a {input[0]} hole in her backyard.\n" +
                $" She ran to grab a {input[1]} shovel. She began to dig and pulled out a huge {input[2]}.\n" +
                $" She called for her mom to inspect what she had found. The girl’s mom immediately {input[3]} to the phone to call someone.\n" +
                $" The mom told the little girl to stay put, but the girl was curious and picked up the {input[2]}. As soon as she\n" +
                $" did the mom {input[4]} at her and grabbed the {input[2]}. Although the girl didn’t understand,\n" +
                $" the mom said the {input[2]} was very valuable and they would make a lot of money from it.");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }

        public void TheRecipe()
        {
            Console.Clear();
            string[] prompts = { "Type Anything!: ", "Type a Noun: ", "Type a Noun: ", "Type an Adjective: ", "Type a Plural Noun: ", "Type a Number: ", "Type a Noun: ", "Type a Noun: ", "A Length of Time: ", "Type an Adverb: ", "Type a Noun: " };
            string[] input = new string[11];

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(prompts[i]);
                input[i] = Console.ReadLine();
            }

            Console.Clear();
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" Recipe for {Capitalize(input[0])}:\n" +
                $" \n" +
                $" Step 1. Start with {rnd.Next(2, 10)} {input[4]}... \n" +
                $" Step 2. Mix in container with {input[5]} pounds of chopped {input[1]}... \n" +
                $" Step 3. Fry mixture over high heat. Sprinkle {rnd.Next(1, 300)} tbsp of {input[7]} juice on top... \n" +
                $" Step 4. Let sit for {input[8]} while you prep the {input[10]}... \n" +
                $" Step 5. Throw the {input[10]} into the mixture and add a pinch of {input[6]} salt... \n" +
                $" Step 6. Finally, garnish with a single {input[2]}... \n" +
                $" \n" +
                $" Stir until {input[3]}. Best served {input[9]}.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }
    }
}
