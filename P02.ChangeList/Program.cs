using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> commands = Console.ReadLine().Split().ToList();

            while (commands[0] != "end") 
            {
                if (commands[0] == "Delete")
                {
                    input.Remove(int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    int commandsNumIndex1 = int.Parse(commands[1]);
                    int commandsNumIndex2 = int.Parse(commands[2]);
                    input.Insert(commandsNumIndex2, commandsNumIndex1);
                }
                for (int i = 0; i < commands.Count; i++)
                {
                    commands.RemoveAt(i);
                    i = -1;
                }
                commands = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
