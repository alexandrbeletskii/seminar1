// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Алгоритм нужно реализовать самостоятельно, встроенную функцию использовать нельзя.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Exponentiation (int num1, int num2)
{
    int result = 1;
    for (int i = 0; i < num2; i++)  
    {
        result *=num1;
    }
    return result;
}


Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation (number1, number2); 

Console.WriteLine($"{number1} в степени {number2} равно {exponentiation}");