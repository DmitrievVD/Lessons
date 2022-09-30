// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arrey = new int [num];
int score = 0;

for (int i = 0; i < arrey.Length; i++)
{
    arrey[i] = new Random().Next(100, 999);
}

for (int i = 0; i < arrey.Length; i++)
{
    if (i != arrey.Length - 1)
    {
        Console.Write($"{arrey[i]}, ");
    }
    else Console.WriteLine($"{arrey[i]}");
    if (arrey[i] % 2 == 0) score++;
}

Console.WriteLine($"Четные числа в массиве: {score}");


