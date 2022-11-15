using System;
using Forest_VM;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Forest f = new Forest();

            Console.WriteLine("Type your name to start");
            f.name = Console.ReadLine();
            Console.WriteLine("Hello"+" " + f.name +"! "+"This program will ask you a couple of questions about biomes and forest types. Please make sure to capitalize the first letter of your answer");


            Console.WriteLine("Type a major biome type");
            f.Biome = Console.ReadLine();
            Console.WriteLine(f.Biome);

            Console.WriteLine("Type a rainforest layer");
            f.Forestlayer = Console.ReadLine();
            Console.WriteLine(f.Forestlayer);
        }

    }
}


