using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework.cs
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.Title = "MadLib";
            Console.WriteLine("Please Enter some information below to do this Mad Lib. Unless otherwise specified, verbs should be in standard present tense <i.e. 'swim' and 'run'>. Adverbs are words modifying verbs <like 'soon', or often ending in 'ly', like 'swiftly'>. Adjectives are words that describe nouns <like 'green' or 'descriptive'>.");

            Console.WriteLine("Holiday: ");
            string holiday = Console.ReadLine();

            Console.WriteLine("Noun: ");
            string noun1 = Console.ReadLine();

            Console.WriteLine("Place: ");
            string place1 = Console.ReadLine();

            Console.WriteLine("Monster: ");
            string monster = Console.ReadLine();

            Console.WriteLine("Adjective: ");
            string adjective1 = Console.ReadLine();

            Console.WriteLine("Body Part (Plural): ");
            string bodyPart = Console.ReadLine();

            Console.WriteLine("Verb: ");
            string verb1 = Console.ReadLine();

            Console.WriteLine("Adjective: ");
            string adjective2 = Console.ReadLine();

            Console.WriteLine("Noun: ");
            string noun2 = Console.ReadLine();

            Console.WriteLine("Food Item: ");
            string foodItem = Console.ReadLine();

            Console.WriteLine("I can't believe it's already {0}! I can't wait to put on my {1} and visit every {2} in my neighborhood. This year, I am going to dress up as a {3} with {4} {5}. Before I {6}, I make sure to grab my {7} {8} to Hold all of my {9}.",  holiday, noun1, place1, monster, adjective1, bodyPart, verb1, adjective2, noun2, foodItem);

        }
    }
}
