// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int MassMax (int[] x)
{
    int max = x[0];
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] > max) max = x[i];
    }
    return max;
}
int MassMin (int[] x)
{
    int min = x[0];
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] < min) min = x[i];
    }
    return min;
}

int[] arrey = new int [5];

for (int i = 0; i < arrey.Length; i++)
{
    arrey[i] = new Random().Next(1, 100);
}

for (int i = 0; i < arrey.Length; i++)
{
    if (i != arrey.Length - 1) Console.Write($"{arrey[i]}, ");
    else Console.WriteLine ($"{arrey[i]}");
}

int max = MassMax (arrey);
int min = MassMin (arrey);


Console.WriteLine($"Разница между максимальным и минимальным элементом: {max - min}");