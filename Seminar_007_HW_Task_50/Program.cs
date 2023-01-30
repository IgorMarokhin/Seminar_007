// Задача 50: Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

Console.Clear();

Console.Write("Введите номер строки массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите номер столбца массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = new int[10, 10];
GetArrayRandomNumbers(array);

PrintArray(array);

if (rows > array.GetLength(0) && columns > array.GetLength(1))
{
    Console.WriteLine("Заданного элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {rows} строки и {columns} столбца  равно {array[rows - 1, columns - 1]}");
}

//////////////////////////////////////////////

void GetArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 50) / 10;
        }
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
         for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}