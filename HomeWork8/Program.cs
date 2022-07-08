/* Задача 54. Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */

 int[,] massi = new int[5, 5];
FillArray(massi);
Print(massi);
for (int i = 0; i < massi.GetLength(0); i++)
    for (int j = 0; j < massi.GetLength(1); j++)
        for (int k = 0; k < massi.GetLength(1); k++)
        {
            if (massi[i, j] <= massi[i, k]) continue;
            int temp = massi[i, j];
            massi[i, j] = massi[i, k];
            massi[i, k] = temp;
        }
System.Console.WriteLine();
Print(massi);
int[,] FillArray(int[,] array)
{
    for (int i = 0; i < massi.GetLength(0); i++)
    {
        for (int j = 0; j < massi.GetLength(1); j++)
        {
            massi[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(massi[i, j] + " ");
        }
        Console.WriteLine();
    }
} 




/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов. */

int m = 4;
int n = 8;

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int minSum = 0;

for (int i = 0; i < array.GetLength(1); i++)
{
    minSum += array[0, i];
}
int minIndex = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int tempSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        tempSum += array[i, j];
    }
    Console.WriteLine($"Сумма {i} сроки: " + tempSum);
    if(minSum > tempSum)
    {
        minSum = tempSum;
        minIndex = i;
    }
}

Console.WriteLine("Строка с наименьшей суммой: " + (minIndex));

void PrintArray(int[,] massi)
{
    for (int rows = 0; rows < massi.GetLength(0); rows++)
    {
        for (int columns = 0; columns < massi.GetLength(1); columns++)
        {
            Console.Write($"{massi[rows, columns]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] massi)
{
    for (int rows = 0; rows < massi.GetLength(0); rows++)
    {
        for (int columns = 0; columns < massi.GetLength(1); columns++)
        {
            massi[rows, columns] = new Random().Next(1, 10);
        }
    }
}


/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. */

int a = Input("a");
int b = Input("b");
int c = Input("c");
int d = Input("d");

int[,] array = new int[a, b];
int[,] newArray = new int[c, d];

FillArray(array);
PrintArray(array);
Console.WriteLine();
FillArray(newArray);
PrintArray(newArray);
Console.WriteLine();

int[,] result = WorkMatrix(array, newArray);
PrintArray(result);

int[,] WorkMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) 
    {
        Console.WriteLine("Произведение двух матриц невозможно");
        return matrix1;
    }
    int[,] outputMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                outputMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return outputMatrix;
}

int Input(string numberName)
{
    Console.Write($"Введите значение для {numberName}: ");
    return Convert.ToInt32(Console.ReadLine());
}
void PrintArray(int[,] massi)
{
    for (int rows = 0; rows < massi.GetLength(0); rows++)
    {
        for (int columns = 0; columns < massi.GetLength(1); columns++)
        {
            Console.Write($"{massi[rows, columns]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] massi)
{
    for (int rows = 0; rows < massi.GetLength(0); rows++)
    {
        for (int columns = 0; columns < massi.GetLength(1); columns++)
        {
            massi[rows, columns] = new Random().Next(1, 10);
        }
    }
}



/*Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.*/


int mas1 = InputInt("Введите размерность 1: ");
int mas2 = InputInt("Введите размерность 2: ");
int mas3 = InputInt("Введите размерность 3: ");
int countNumbers = 89;

if (mas1 * mas2 * mas3 > countNumbers)
{
    return;
}

int[,,] numbers = CreateArray(mas1, mas2, mas3);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        for (int k = 0; k < numbers.GetLength(2); k++)
        {
            Console.Write($"[{i},{j},{k}] {numbers[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,,] CreateArray(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] digitValues = new int[countNumbers];
    int value = 10;
    for (int i = 0; i < digitValues.Length; i++)
        digitValues[i] = value++;

    for (int i = 0; i < digitValues.Length; i++)
    {
        int randomIndex = new Random().Next(0, digitValues.Length);
        int temp = digitValues[i];
        digitValues[i] = digitValues[randomIndex];
        digitValues[randomIndex] = temp;
    }

    int valueIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = digitValues[valueIndex++];
            }
        }
    }

    return array;
}


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}


/*Задача 62: Заполните спирально массив 4 на 4.*/

int n = int.Parse(Console.ReadLine());

int[,] array = new int[n, n];

int value = 1;
int i = 0;
int j = 0;

while(value <= n * n)
{
array[i, j] = value;
if(i <= j + 1 && i + j < n - 1)
++j;
else if (i < j && i + j >= n - 1)
++i;
else if (i >= j && i + j > n - 1)
--j;
else
--i;
++value;

}

for(int x = 0; x < array.GetLength(0); x++)
{
for(int y = 0; y < array.GetLength(1); y++)
{
Console.Write(array[x, y] + " ");
}
Console.WriteLine();
}