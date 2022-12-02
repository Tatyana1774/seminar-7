﻿/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int rows = ReadInt("Введите количество строк m: ");
int columns = ReadInt("Введите количество столбцов n: ");
double[,] numbers = new double[rows, columns];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);
double average(double[,] array, int columns)
{
double sum = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
sum = sum + numbers[i, columns];
double average = sum / numbers.GetLength(0);
return average;
}
Console.WriteLine();
for (int j = 0; j < numbers.GetLength(1); j++)
Console.WriteLine($"среднее арифметическое{j} = {average(numbers, j)}");

void FillMatrixRandomNumbers(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(1, 10);
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