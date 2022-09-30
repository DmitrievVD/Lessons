// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arrey = new int [5];
int result = 0;
int i = 0;

while (i < arrey.Length)
{
    arrey[i] = new Random().Next(1, 100);
    i++;
}

i = 0;

while (i < arrey.Length)
{
    if (i != arrey.Length - 1)
    {
        Console.Write($"{arrey[i]}, ");
    }
    else Console.WriteLine($"{arrey[i]}");
    if (i % 2 == 1) 
    {
        result = result + arrey[i];
    }
    i++;
}

Console.WriteLine($"Сумма элементов на нечетных позициях: {result}");


