// **Задача 39:** Напишите программу, 
// которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


Console.Write("Напишите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [N];
int help = 0;
int m = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 10);
}
for (int i = 0; i < arr.Length; i++)
{
    if (i == arr.Length - 1) Console.Write($"{arr[i]} ");
    else Console.Write($"{arr[i]}, ");

}
for (int i = 0; i < arr.Length/2; i++)
{
    m = arr.Length- 1 -i;
    help = arr[i];
    arr[i] = arr[m];
    arr[arr.Length- 1 -i] = help;
}
Console.WriteLine();
for (int i = 0; i < arr.Length; i++)
{
    if (i == arr.Length - 1) Console.Write($"{arr[i]} ");
    else Console.Write($"{arr[i]}, ");

}
