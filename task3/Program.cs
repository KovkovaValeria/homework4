// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите число элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

void FillArray(int collection)
{
	int[] arr = new int[collection];
	Console.WriteLine("Введите элементы массива: ");
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = Convert.ToInt32(Console.ReadLine());
	}
	Console.Write("[");
	foreach (var intem in arr)
	{
		Console.Write($"{intem}, ");
	}
	Console.Write("\b\b]");
}
FillArray(num);