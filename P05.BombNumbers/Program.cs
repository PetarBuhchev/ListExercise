using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> magicNums = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == magicNums[0])
                {
                    for (int m = i-1; m > i - magicNums[1] - 1; m--)
                    {
                        if (m < 0)
                        {
                            break;
                        }
                        else
                        {
                            input.RemoveAt(m);
                        }
                    }
                }
            }
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == magicNums[0])
                {
                    for (int j = i + 1; j <= i + magicNums[1]; j++) // i+1 = 2
                    {
                        if (j > input.Count)
                        {
                            break;
                        }
                        else
                        {
                            input.RemoveAt(j);
                        }
                    }
                }
            }

            int sum = 0;
            input.Remove(magicNums[0]);
            for (int i = 0;i < input.Count;i++) 
            {
                sum += input[i];
            }
            Console.WriteLine(sum);
        }
    }
}
