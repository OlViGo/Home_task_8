// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
//  произведение двух матриц.(посмотрите как реализуется произведение матриц,
//  там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Введите строки и столбцы матриц:");
int m = Numbers("Введите число строк 1-й матрицы: ");
int n = Numbers("Введите число столбцов 1-й матрицы: ");
int l = Numbers("Введите число строк 2-й матрицы: ");
int k = Numbers("Введите число столбцов 2-й матрицы: ");

int[,] firstMartrix = new int[m, n];
FillArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMartrix);

int[,] secondMartrix = new int[l, k];
FillArray(secondMartrix);
Console.WriteLine($"Вторая матрица:");
PrintArray(secondMartrix);

int[,] resultMatrix = new int[m,k];

ResultMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);

void ResultMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int Numbers(string input)
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine());
  return output;
 }

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,10);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
