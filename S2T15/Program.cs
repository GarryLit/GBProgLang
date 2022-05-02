/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

 
Console.WriteLine("Введите номер дня недели");

int WeekDay = Convert.ToInt32(Console.ReadLine());

if (WeekDay < 1 || WeekDay > 7){
    Console.WriteLine("Выучи дни недели, двоечник!");
    Console.WriteLine("А потом бегом в школу!");
}

if (WeekDay == 6 || WeekDay == 7)
    Console.WriteLine("Сегодня выходной!");
else
    Console.WriteLine("Ты еще здесь? Бегом в школу!");

