/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
int GetNumber(string message)
{
   int result = 0;
   bool isCorrect = false;

   while(!isCorrect)
   {

    Console.WriteLine(message);

    if ((int.TryParse(Console.ReadLine(), out result) && (result != 0) ))
    {
        isCorrect = true;
    } 
    else
    {
        Console.WriteLine("Некорректно ввели число");
    }
   } 
   return result;
}

int[,] InitMatrix(int M, int N)
{
    int[,] matrix = new int[M, N];
    Random rnd = new Random();
    for(int i = 0; i<matrix.GetLength(0); i++)
    {   for(int j = 0; j<matrix.GetLength(1); j++)
       {
         matrix[i,j] = rnd.Next(100);
       }
    }
    return matrix;
}

int Search(int[,] matrix)
{
    int m = GetNumber("Введите строку");
    if (m > matrix.GetLength(0))
    {
        Console.WriteLine("такого числа в массиве нет");
        return -1;
    }
    int n = GetNumber("Введите столбец");
    if (m > matrix.GetLength(1))
    {
        Console.WriteLine("такого числа в массиве нет");
        return -1;
    }
    return matrix[m-1,n-1];
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i,j]} ");
}
Console.WriteLine();
}
}


int [,] matrix = InitMatrix(GetNumber("Колво строк"),GetNumber("Колво столбцов"));
PrintMatrix(matrix);
int result = Search(matrix);
if (result != -1)
{
    Console.WriteLine(result);
}