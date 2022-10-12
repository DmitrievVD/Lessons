// **Задача 46:** Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

void CreateAndPrintArrey (int x, int y)
{
    int [,] arrey = new int [x,y];

    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i, j] = new Random().Next(-10, 10);
            Console.Write($"{arrey[i,j]}     ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine()); 

CreateAndPrintArrey (m, n);
