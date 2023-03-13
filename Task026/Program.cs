// Задача 26. Напишите программу, которая
// принимает на вход число и выдает количество
// цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите натуральное число");
// string number = Console.ReadLine();

// int Digits(string num)
// {
//    int n = num.Length;
//     return n;
// }
// int digits = Digits(number);

// Console.WriteLine($"Количество цифр в числе равно {digits}");



Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int Digits(int num)
{
   int count=0;
   while(num!=0)
   {
    num=num/10;
    count+=1;
   }
    return count;
}
int digits = Digits(number);
Console.WriteLine($"Количество цифр в числе равно {digits}");