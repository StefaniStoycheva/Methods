﻿namespace _05.HappyNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int digit1 = 1; digit1 <= n; digit1++)
            {
                for (int digit2 = 0;digit2 <= 9; digit2++)
                {
                    for(int digit3 = 0; digit3 <= 9; digit3++)
                    {
                        for (int digit4 = 0; digit4 <= 9; digit4++)
                        {
                            if (digit1 + digit2 == n && digit4 + digit3 == n)
                            {
                                Console.Write($"{digit1}{digit2}{digit3}{digit4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}