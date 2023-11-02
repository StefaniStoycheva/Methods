

static void PrintNum(int num) //define
{
    if (num > 0)
    {
        Console.WriteLine($"The number {num} is positive.");
    } else if (num < 0)
    {
        Console.WriteLine($"The number {num} is negative.");
    }
    else
    {
        Console.WriteLine($"The number {num} is zero.");
    }
}

int number = int.Parse(Console.ReadLine()); //action

PrintNum(number); //print this / calling the method