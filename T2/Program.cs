/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
  и на выходе показывает вторую цифру этого числа. */

 
 Console.WriteLine("Введите трехзначное число");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Number % 100 / 10); 
