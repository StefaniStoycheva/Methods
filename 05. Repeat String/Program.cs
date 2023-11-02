static void RepeatString(string text, int repeatCount)
{
    for (int i = 0; i < repeatCount; i++)
    {
        Console.Write(text);
    }
}
string text = Console.ReadLine();
int repeatCount = int.Parse(Console.ReadLine());

RepeatString(text, repeatCount);