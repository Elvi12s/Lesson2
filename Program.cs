// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("введите 3х значное число");
int num= Convert.ToInt32(Console.ReadLine());
int num2;
num2=(num/10)%10;
Console.WriteLine(num2);