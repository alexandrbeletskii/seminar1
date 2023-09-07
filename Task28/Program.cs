// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int productNumbers(int num)
{
    int product = 1;
    for (int i = 1; i <= num; i++)
{
    checked

   {
    product = product * i;
   }
}
   return product;
    }

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int result =  productNumbers(number);    
Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");