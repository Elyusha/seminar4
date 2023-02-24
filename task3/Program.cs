// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] GetArray(int maxValue)
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Получен массив из 8ми случайных чисел: ");
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.Write("Введите максимальное значение числа в массиве: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] listNumber = GetArray(maxValue);
PrintArray(listNumber);