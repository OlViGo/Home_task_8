// Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

    Console.WriteLine("Введите число строк");
    int size1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число столбцов");
    int size2 = int.Parse(Console.ReadLine());
    int[,] digits = new int[size1, size2];
FillArrayRandomNumbers(digits);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(digits);
for (int i = 0; i < digits.GetLength(0); i++)
{
    for (int j = 0; j < digits.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < digits.GetLength(1) - 1; z++)
        {
            if (digits[i, z] < digits[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
            {
                int temp = 0;
                temp = digits[i, z];
                digits[i, z] = digits[i, z + 1];
                digits[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(digits);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
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

