// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.Write("Введите кол-во строк: ");
// int m = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите кол-во столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine()); 

// int [,] arrey = new int [m,n];

// for (int i = 0; i < arrey.GetLength(0); i++)
// {
//     for (int j = 0; j < arrey.GetLength(1); j++)
//     {
//         arrey[i, j] = i+j;
//         Console.Write($"{arrey[i,j]}     ");
//     }
//         Console.WriteLine();
// }
// Console.WriteLine("Hello, World!");

int[] arr = {7, 2, 9, 1, 5,};
int max = arr[0];
int help = 0;
int score = 0;
int n = 0;
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}
for (int i = 0; i < arr.Length; i++){
    n=i;
    max = arr[i];
    while(n < arr.Length){
        if (max < arr[n]){
            help = max;
            max = arr[n];
            arr[n] = help;

        }
        n++;
    }
    help = arr[score];
    arr[score] = max;
    score++;
}

// for (int i = 0; i < arr.Length; i++)
// {
//     max = arr[i];
//     while(n < arr.Length){
//     if (max < arr[n]) 
//     {
//         max = arr[n];
//         arr [n] = arr[score];
//         arr[score] = max;    
//         score++;
//     }
//     n++;
//     }
//     n = 1;
// }


Console.WriteLine();

for (int i = 0; i < arr.Length; i++){
    Console.Write($"{arr[i]} ");
}


