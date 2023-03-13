//Задача 24: Напишите программу, которая
// 1. Принимает на вход число (А) и 
// 2. Выдает сумму чисел от 1 до А

// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

void Sum(int num)

{
int sum=0;
for(int i=0; i<=num; i++)
{
    sum=sum+i;
}
    Console.WriteLine($"Сумма чисел от 1 до {num} равна {sum}");
}
 Sum(number);
