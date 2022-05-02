/*
Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше
Доп. задача с усложнением: на отгадывание дается 3 попытки.

По возможности использовать функции.
*/

int NumberAttempts = 1;
int RandomNumber = new Random().Next(1,10);

int UserNumber = 0;

Console.Write("Загадано случайное число от 1 до 9. Попробуйте угадать с трех попыток");
Console.WriteLine("");

//Console.WriteLine(RandomNumber);

while (NumberAttempts < 4){
    Console.Write("Попытка " + NumberAttempts + " ");
    Console.Write("Введите Ваш вариант ");


    UserNumber = Convert.ToInt32(Console.ReadLine());

    if (UserNumber == RandomNumber) {
        Console.Write("Угадано!Браво!!!!!!! Вам потребовалось  " + NumberAttempts + " Попыток");
        break;
    }    
    if (UserNumber < RandomNumber) 
        Console.WriteLine("Нет! Загаданное число больше ");
    
    if (UserNumber > RandomNumber)
        Console.WriteLine("Нет! Загаданное число меньше");
             
    NumberAttempts++;
}

        



