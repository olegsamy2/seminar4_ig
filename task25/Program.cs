// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А");	
int NumA = Convert.ToInt32(Console.ReadLine());	
Console.WriteLine("Введите число B");	
int NumB = Convert.ToInt32(Console.ReadLine());	
	
int i;	
int sum=1;	
	
	
for(i=1; i<=NumB; i++)	
{	
	sum=sum*NumA;
}	
 Console.WriteLine(sum);	
