//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.			
//452 -> 11			
//82 -> 10			
// 9012 -> 12			

Console.WriteLine("Введите число  ");
int number = Convert.ToInt32(Console.ReadLine());

int numberprint = number;  // переменная на печать			
int sum = 0;
int digit;  // цифра от числа			

for (; number > 0;)
{
    digit = number % 10;    // // получаем цифру справа			
    sum = sum + digit;
    number = number / 10;     // что б сработал (%) при следующей итерации и взял следующую цифру справа		
}

Console.WriteLine("Сумма значений цифр в числе " + numberprint + " равна " + sum);