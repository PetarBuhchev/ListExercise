using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> commands = Console.ReadLine().Split().ToList();
            while (commands[0] != "End") 
            {
                if (commands[0] == "Add")
                {
                    int commandsNumIndex1 = int.Parse(commands[1]);
                    input.Add(commandsNumIndex1);
                }
                else if (commands[0] == "Insert")
                {
                    int commandsNumIndex1 = int.Parse(commands[1]);
                    int commandsNumIndex2 = int.Parse(commands[2]);
                    if (commandsNumIndex2 <= input.Count)
                    {
                    input.Insert(commandsNumIndex2, commandsNumIndex1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (commands[0] == "Remove")
                {
                    int commandsNumIndex1 = int.Parse(commands[1]);
                    if (commandsNumIndex1 <= input.Count) 
                    {
                        input.RemoveAt(commandsNumIndex1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (commands[1] == "left")
                {
                    int commandsNumIndex2 = int.Parse(commands[2]);
                    for (int i = 0; i < commandsNumIndex2; i++)
                    {
                        input.Add(input[0]);
                        input.RemoveAt(0);
                    }
                }
                else if (commands[1] == "right")
                {
                    List<int> newList = new List<int>();
                    int commandsNumIndex2 = int.Parse(commands[2]);

                    for(int i = 0;i < commandsNumIndex2; i++) 
                    {
                        newList.Add(input[input.Count-1-i]);
                    }
                    newList.AddRange(input);
                    for (int i = 0; i < commandsNumIndex2; i++)
                    {
                        newList.RemoveAt(input.Count -i);
                    }

                    input = newList;
                }
                for(int i = 0;i < commands.Count;i++) 
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
