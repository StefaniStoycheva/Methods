

static char FindGreaterChar(char ch1, char ch2)
{
    if (n1 > n2)
        {
            Console.WriteLine(n1);
        } else 
        {
            Console.WriteLine(n2); 
        }
}
static void GreatestValue(string type)
{
    if (type == "int")
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        if (n1 > n2)
        {
            Console.WriteLine(n1);
        } else 
        {
            Console.WriteLine(n2); 
        }
        
    } else if (type == "char")
    {
        char ch1 = char.Parse(Console.ReadLine());
        char ch2 = char.Parse(Console.ReadLine());
        if (ch1 > ch2)
        {
            Console.WriteLine(ch1);
        }
        else
        {
            Console.WriteLine(ch2);
        }
    } else if (type == "string")
    {
        string st1 = Console.ReadLine();
        string st2 = Console.ReadLine();
        if (st1.Length > st2.Length)
        {
            Console.WriteLine(st1);
        }
        else
        {
            Console.WriteLine(st2);
        }
    }
}
GreatestValue();