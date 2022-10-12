/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 
*/


// int [,] CreateArrey (int x, int z) 
// {
//     int [,] arrey = new int [x,z];

//     for (int i = 0; i < arrey.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrey.GetLength(1); j++)
//         {
//             arrey[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return arrey;
// }

// void PrintArrey (int [,] arr ) 
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i,j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите ширину массива: ");
// int widthArrey = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите высоту массива: ");
// int heightArrey = Convert.ToInt32(Console.ReadLine());

// int [,] arrey = CreateArrey(widthArrey, heightArrey);
// PrintArrey(arrey);

// int max = 0;
// int help = 0;
// int n = 0;

// for (int i = 0; i < arrey.GetLength(0); i++)
// {
//     for (int j = 0; j < arrey.GetLength(1); j++)
//     {
//         n=j;
//         max = arrey[i,j];
//         while(n < arrey.GetLength(1))
//         {
//             if (max < arrey[i,n])
//             {
//                 help = max;
//                 max = arrey[i,n];
//                 arrey[i,n] = help;
//             }
//             n++;
//         }
//         help = arrey[i, j];
//         arrey[i,j] = max;
//     }
// }
// Console.WriteLine();
// PrintArrey(arrey);



/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

// int [,] CreateArrey (int x, int z) 
// {
//     int [,] arrey = new int [x,z];

//     for (int i = 0; i < arrey.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrey.GetLength(1); j++)
//         {
//             arrey[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return arrey;
// }

// void PrintArrey (int [,] arr ) 
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i,j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите ширину массива: ");
// int widthArrey = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите высоту массива: ");
// int heightArrey = Convert.ToInt32(Console.ReadLine());

// int [] arreyMaxWidth = new int [widthArrey];
// int min = 0;
// int score = 0;

// int [,] arrey = CreateArrey(widthArrey, heightArrey);
// PrintArrey(arrey);
// Console.WriteLine();

// for (int i = 0; i < arrey.GetLength(0); i++)
// {
//     for (int j = 0; j < arrey.GetLength(1); j++)
//     {
//         arreyMaxWidth[i] +=  arrey[i,j];
//     }
// }


// min = arreyMaxWidth[0];
// for (int i = 0; i < arreyMaxWidth.Length; i++)
// {
//     if (min > arreyMaxWidth[i]) 
//     {
//         min = arreyMaxWidth[i];
//         score = i;
//     }
    
// }
// Console.WriteLine($"Наименьшая сумма {min} на строке: {score+1}");


/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int [,] CreateArrey (int x, int z) {
    int [,] arrey = new int [x,z];

    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i, j] = new Random().Next(0, 10);
        }
    }
    return arrey;
}

void PrintArrey (int [,] arr ) {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}   ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите ширину массива: ");
int widthArrey = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту массива: ");
int heightArrey = Convert.ToInt32(Console.ReadLine());

int [,] arrey1 = CreateArrey(widthArrey, heightArrey);
PrintArrey(arrey1);
Console.WriteLine($"*");

int [,] arrey2 = CreateArrey(widthArrey, heightArrey);
PrintArrey(arrey2);
Console.WriteLine($"=");

int[,] arreySum = CreateArrey(widthArrey, heightArrey);

for (int i = 0; i < arreySum.GetLength(0); i++)
{
    for (int j = 0; j < arreySum.GetLength(0); j++)
    {
        arreySum[i,j] = arrey1[i,j] * arrey2[i,j];
    }
}
PrintArrey(arreySum);

/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/




/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
Console.WriteLine();
Console.WriteLine("Hello, World!");
