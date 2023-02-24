// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int CalcSum(int num)
{
    int sum = 0;
    if (num >= 0 && num <= 9) sum = num;
    else
    {
        while (num > 0)
        {
            int temp = num % 10;
            sum = sum + temp;
            num = num / 10;
        }
    }
    return sum;
}

Console.WriteLine("Введите любое целое число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CalcSum(number));
