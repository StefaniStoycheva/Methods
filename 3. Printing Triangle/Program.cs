
//method that prints the line
static void PrintLine(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}



//method that prints first and second half
static void PrintTriangle(int n)
{
    for(int line = 1; line <= n; line++)
    {
        PrintLine(1, line);
    }
    for(int line = n - 1 ;line >= 1; line--)
    {
        PrintLine(1, line);
    }
}
int num = int.Parse(Console.ReadLine());
PrintTriangle(num);