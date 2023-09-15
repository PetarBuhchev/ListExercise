using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            
            List<string> commands = Console.ReadLine().Split().ToList();
            while (commands[0] != "end")
            {
                if (commands[0] == "Add")
                {
                    int commandsNumIndex1 = int.Parse(commands[1]);
                    input.Add(commandsNumIndex1);
                }
                else
                {
                    int commandsNumIndex0 = int.Parse(commands[0]);
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] + commandsNumIndex0 < maxCapacity)
                        {
                            input[i] += commandsNumIndex0;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
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
