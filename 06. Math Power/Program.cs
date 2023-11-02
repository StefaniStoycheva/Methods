static void MathPower(int baseNum, int powerNum)
{
    double result = Math.Pow(baseNum, powerNum);
    Console.WriteLine(result);
}
int baseN = int.Parse(Console.ReadLine());
int powerN = int.Parse(Console.ReadLine());

MathPower(baseN, powerN);