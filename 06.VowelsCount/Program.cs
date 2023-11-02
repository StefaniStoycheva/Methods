string text = Console.ReadLine();

Console.WriteLine(GetVowelsCount(text));

static int GetVowelsCount (string text) //this method returns value // if it was static void, it would have CW instead of return and would be printing
{
    int count = 0; // count vowels

    for (int position = 0; position <= text.Length - 1; position++)
    {
        char symbol = text[position];// symbol of the current position
        if (symbol == 'A' || symbol == 'a' 
            || symbol == 'E' || symbol == 'e' || symbol == 'I' || symbol == 'i' 
            || symbol == 'O' || symbol == 'o' || symbol == 'U' || symbol == 'u')
        {
            count++;
        }
    }
    return count;
}