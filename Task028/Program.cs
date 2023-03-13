//Задача 28: Напишите программу, которая
// 1. Принимает на вход число (N) и 
// 2. Выдает произведение чисел от 1 до N

// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

void Product(int num)

{
int prod=1;
for(int i=1; i<=num; i++)
{
    prod=prod*i;
}
    Console.WriteLine($"Произведение чисел от 1 до {num} равна {prod}");
}
 Product(number);

