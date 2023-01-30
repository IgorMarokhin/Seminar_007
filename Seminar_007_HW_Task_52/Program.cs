// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int n = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int m = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(n, m, 0, 10);

for (int j = 0; j < array.GetLength(1); j++)
{
	double avarage = 0;
	for (int i = 0; i < array.GetLength(0); i++)
	{
		avarage = (avarage + array[i, j]);
	}
	avarage = avarage / n;
	Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(array);

/////////////////////////////////////////////

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{

	for (int i = 0; i < array.GetLength(0); i++)
	{
		Console.Write("[ ");
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.Write("]");
		Console.WriteLine("");
	}
}