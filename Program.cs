﻿


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива ");
int dimension = Convert.ToInt32(Console.ReadLine());
int[]array = new int[dimension];
ArrayRandomNumbers(array);
Console.WriteLine("массив: ");
PrintArray(array);
int sum = 0;

for (int j = 0; j < array.Length; j= j + 2)
    sum = sum + array[j];
Console.WriteLine($"всего {array.Length} чисел, сумма элементов стоящих на нечетных позициях = {sum}");

void ArrayRandomNumbers(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = new Random().Next(1, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

