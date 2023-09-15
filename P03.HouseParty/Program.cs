using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCommands = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();
            List<string> commands = new List<string>();

            for (int i = 0; i < numCommands; i++)
            {
                commands = Console.ReadLine().Split().ToList();
                if (commands.Count == 3)
                {
                    if (names.Contains(commands[0]))
                    {
                        Console.WriteLine($"{commands[0]} is already in the list!");
                    }
                    else
                    {
                    names.Add(commands[0]);
                    }
                }
                else if (commands.Count == 4) 
                {
                    if (names.Contains(commands[0]))
                    {
                        names.Remove(commands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{commands[0]} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
