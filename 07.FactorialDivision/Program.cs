int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

int factFirstNumber = CalculateFactoriel(num1);
int factSecondNumber = CalculateFactoriel(num2);

Console.WriteLine(factFirstNumber / factSecondNumber);

static int CalculateFactoriel(int number)  
{
    int fact = 1;
    for (int i = 1; i <= number; i++)
    {
        fact = fact * i;
    }
    return fact;
}