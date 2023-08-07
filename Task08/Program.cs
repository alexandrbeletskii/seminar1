// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (number < 0) 
{
    Console.WriteLine("Некорректный ввод");
}
if (number == 1) 
{
    Console.WriteLine("В заданном диапозоне четных чисел нет");
}
while (count <= number)
{
        Console.Write($"{count} ");
    count=count + 2;
}
