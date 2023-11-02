namespace _04.LetterCombinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char missLetter = char.Parse(Console.ReadLine());

            int countValid = 0;

            for (char letter1 = startLetter; letter1 <= endLetter; letter1++)
            {
                for (char letter2 = startLetter; letter2 <= endLetter; letter2++)
                {
                    for(char letter3 = startLetter; letter3 <= endLetter; letter3++)
                    {
                        if (letter1 != missLetter && letter2 != missLetter && letter3 != missLetter)
                        {
                            Console.Write($"{letter1}{letter2}{letter3} ");
                            countValid++;
                        }
                    }
                }
            }
            Console.WriteLine(); //empty CW so that it can move a line!!!
            Console.WriteLine(countValid);
        }
    }
}