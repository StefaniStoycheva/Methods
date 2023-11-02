int max1 = int.Parse(Console.ReadLine()); //max value first digit  
int max2 = int.Parse(Console.ReadLine()); 
int max3 = int.Parse(Console.ReadLine()); //max value of third digit

for (int firstDigit = 2; firstDigit <= max1; firstDigit += 2)
{
    for (int secondDigit = 1; secondDigit <= max2; secondDigit++)  
    {
        for (int thirdDigit = 2; thirdDigit <= max3; thirdDigit += 2)
        {
            if (secondDigit == 2 || secondDigit == 3 || secondDigit == 5 || secondDigit == 7)
            {
                //sec digit is simple num from 2 to 7 -> valid PIN
                Console.WriteLine($"{firstDigit}{secondDigit}{thirdDigit}");
            }
        }
    }
}