﻿// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] array = new int[8]; // 0 1 2 3 4 5 6 7

// int[] array2 = new int[]{43, 54, 66, 3, -55, 5, 53, 6};
// int[] array3 = new int[12]{43, 54, 66, 3, -55, 5, 53, 6, 54, 4, 23, 34};
// int[] array1 = {43, 54, 66, 3, -55, 5, 53, 6};

// array[0] = 465;
// array[7] = 23;
// //array[12] = 76;

// for (int i = 0; i < array.Length; i++)
// {
// array[i] = i * i;
// Console.Write(array[i] + " ");
// }

void FillArray(int[] array)
{
    Random rnd =    new Random();
    for (int i = 0; i < array.Length; i++)
{
    array[i] =  rnd.Next(2);
   }
}

void PrintArray(int[] array)
{
    Random rnd =    new Random();
    for (int i = 0; i < array.Length; i++)
{
       Console.Write(array[i] + " ");
}
}


int[] arr = new int[8];

FillArray(arr);
PrintArray(arr);