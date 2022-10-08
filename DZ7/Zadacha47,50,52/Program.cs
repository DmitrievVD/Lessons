int [,] CreateArrey (int x, int z) // Функция которая создает массив.
{
    int [,] arrey = new int [x,z];

    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i, j] = new Random().Next(-10, 10);
        }
    }
    return arrey;
}
void PrintArrey (int [,] arr ) // Функция которая печатает массив.
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}       ");
        }
        Console.WriteLine();
    }
}




// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Console.Write("Введите ширину массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите высоту массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int [,] arrey = CreateArrey (m, n);
// PrintArrey(arrey); 





// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// int m = new Random().Next(1, 10);
// int n = new Random().Next(1, 10);

// int [,] arrey = CreateArrey (m, n);
// PrintArrey(arrey); 

// Console.Write("Введите возицию по горизонтали: ");
// int gorizontal = Convert.ToInt32(Console.ReadLine());
// if ( gorizontal > m) 
// {
//     Console.Write($"Ошибка!!! Тут только {m} строки.");
//     Console.WriteLine();
// }
// Console.Write("Введите возицию по вертикали: ");
// int vertical = Convert.ToInt32(Console.ReadLine());
// if ( vertical > n) 
// {
//     Console.Write($"Ошибка!!! Тут только {n} колонок.");
//     Console.WriteLine();
// }

// Console.Write($"Элемент на позиции ({gorizontal},{vertical}): {arrey[gorizontal-1, vertical-1]}");






// Задача 52.
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Введите ширину массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] arrey = CreateArrey (m, n);
PrintArrey(arrey); 
int i = 0;
int j = 0;
double result = 0;
while (j < arrey.GetLength(1))
{
    while (i < arrey.GetLength(0))
    {
        result += arrey[i,j];
        i++;
    }
    Console.WriteLine($"Среднее арифметическое {j+1}го столбца : {result/i}");
    result = 0;
    i = 0;
    j++;
}