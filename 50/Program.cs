/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */
int rows = ReadInt("Введите количество строк m: ");
int columns = ReadInt("Введите количество столбцов n: ");
double[,] numbers = new double[rows, columns];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

void FillMatrixRandomNumbers(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(-10, 10);
}
}
}

void WriteMatrix(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i, j] + " ");
}
Console.WriteLine();
}
Console.WriteLine();
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введите позицию A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (A> (numbers.GetLength(0) - 1) || B > (numbers.GetLength(1)))
{
Console.WriteLine("Такого числа в массиве нет");
}
else
{
Console.WriteLine($"данное число находится на позиции {A} {B} = {numbers[A, B]}");
}