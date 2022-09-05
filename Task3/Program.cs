/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49*/

Console.WriteLine("Введите m 1-й матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n 1-й матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите l 2-й матрицы: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите p 2-й матрицы: ");
int p = Convert.ToInt32(Console.ReadLine());

int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[l, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int k = 0; k < firstMartrix.GetLength(1); k++)
        {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
        }
        resultMatrix[i,j] = sum;
    }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray (int[,] array)
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