// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
//https://github.com/profimars/task54
void CreateArray(int[,] A)
{
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            A[i, j] = rnd.Next(1, 10);
        }
}

void PrintArray(int[,] A)
{
    Console.WriteLine();
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write($"{A[i, j],3}   ");
        Console.WriteLine();
    }
}

void OrderLines(int[,] A)
{
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    bool isSorted = false;
    while (isSorted == false)
    {
        isSorted = true;
        for (int i = 0; i < m - 0; i++)
        {
            for (int j = 0; j < n - 0 - 1; j++)
            {
                if (A[i, j] < A[i, j + 1])
                {
                    int q = A[i, j];
                    A[i, j] = A[i, j + 1];
                    A[i, j + 1] = q;
                    isSorted = false;
                }
            }
        }
    }
}

Console.WriteLine("Введите количество строк матрицы m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] A = new int[m, n];
CreateArray(A);
PrintArray(A);
OrderLines(A);
PrintArray(A);