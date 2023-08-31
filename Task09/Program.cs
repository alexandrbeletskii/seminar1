// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапозона 10-99-> {number}");

// int FirstDigit = number / 10;
// int SecondDigit = number % 10;

// // if (FirstDigit > SecondDigit) Console.WriteLine($"Наибольшая цифра числа -> {FirstDigit}");
// // else Console.WriteLine($"Наибольшая цифра числа -> {SecondDigit}");

// int maxDigit = FirstDigit > SecondDigit ? FirstDigit : SecondDigit;
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit1 = MaxDigit(12);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit1}");

int maxDigit2 = MaxDigit(98);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit2}");

int MaxDigit(int num)
{
    int FirstDigit = num / 10;
    int SecondDigit = num % 10;
    // if (FirstDigit > SecondDigit) return FirstDigit;
    // return SecondDigit;
    return FirstDigit > SecondDigit ? FirstDigit : SecondDigit;
}