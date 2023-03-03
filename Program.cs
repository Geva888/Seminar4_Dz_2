// Напишите программу, которая принимает на вход число и
//  выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputInt(string prompt)
{
    System.Console.WriteLine($"{prompt} -->");
    return Convert.ToInt32(Console.ReadLine());
}
int Sum(int num)
{
    int adv = 0;
    int countNumber = 0;
    while(num > 0)
    {
        adv = num - num % 10;
        countNumber = countNumber + (num - adv);
        num /= 10;
    }
    return countNumber;   
}

int userNumber = InputInt("Введите число");
System.Console.WriteLine($"Сумма цифр числа {userNumber} = {Sum(userNumber)}");

