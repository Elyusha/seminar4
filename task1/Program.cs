// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int CalcDeg(int num1, int num2)
{
    int deg = 1;
    for (int i = 1; i <= num2; i++)
    {
        deg = deg * num1;
    }
    return deg;
}

Console.WriteLine("Введите первое число:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CalcDeg(A, B));


