// Задача 35:Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2]-> 0

// [10, 11, 12, 13, 14]-> 5

Console.Clear();
int size = 123;
int min = 0;
int max = 999;

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintCountArray(int[] arr)
{
    int count = 1;
    System.Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
        if (arr[i] >= 10 && arr[i] <= 99) count++;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество чисел из диапазона [10, 99] равно {count}");
    System.Console.WriteLine();
}

PrintCountArray(FillArray(size, min, max));