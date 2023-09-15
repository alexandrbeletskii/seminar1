﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int CountTowDigitNumber(int[] arr, int min, int max)
{
    int count=0;
     for (int i = 0; i < arr.Length; i++)
     {
if (arr[i]>=min && arr[i]<=max) count++;
     }
     return count;
}


int[] array = CreateArrayRndInt(123, -100, 123);
PrintArray(array);
Console.WriteLine();
int result = CountTowDigitNumber(array,10,99);
Console.WriteLine($"Количество чисел в в заданном диапозон равно {result}");