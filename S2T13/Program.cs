/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число");
int UserNumber = Convert.ToInt32(Console.ReadLine());

if (UserNumber < 100)
    Console.WriteLine("Третьей цифры нет");
else {
    while(UserNumber >=1000)
      UserNumber /=10;
    
    Console.WriteLine(UserNumber % 10);
}

    


