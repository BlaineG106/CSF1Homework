﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLoops.cs
{
    class FruitLoops1
    {
        static void Main(string[] args)
        {
            Console.Title = "Fruit Loops 1";
            string[] fruits = new string[6];
            fruits[0] = "apple";
            fruits[1] = "pear";
            fruits[2] = "mango";
            fruits[3] = "peach";
            fruits[4] = "orange";
            fruits[5] = "grape";

            for (int fruitsList = 0; fruitsList <= fruits.Length - 1; fruitsList++)
            {
                Console.WriteLine(fruits[fruitsList]);
            }
        }
    }
}
