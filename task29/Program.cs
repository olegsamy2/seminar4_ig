// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран. Вводим массив через консоль

int[] array = new int [8];	
	
for (int i = 0; i < array.Length; i++)	
{	
 int n = 1+i;	
 Console.Write("\n Введите " + n + " элемент массива : " );	
 array[i] = int.Parse(Console.ReadLine());	
}	
	
Console.WriteLine("\n Введен массив из 8 элементов");	
	
Console.WriteLine(string.Join(" ; ", array));	


