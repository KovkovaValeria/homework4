// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
while (a > 0)
{
	int num = a % 10;
	a = a / 10;
	b = num + b;
}
Console.WriteLine($"Сумма цифр равна: {b}");

