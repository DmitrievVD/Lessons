// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] arrey = new int [5];

for (int i = 0; i < arrey.Length; i++)
{
    Console.WriteLine($"Введите {i + 1}е число: ");
    arrey[i] = Convert.ToInt32(Console.ReadLine());
    
}
// for (int i = 0; i < arrey.Length; i++)
// {
//     Console.WriteLine($"{i} ||  {arrey[i]}");
// }
// Console.WriteLine("Hello, World!");
Console.WriteLine($"Введите число которое надо найти: ");
int num = Convert.ToInt32(Console.ReadLine());
string help = "Нет";


for (int i = 0; i < arrey.Length; i++)
{
    // if (num == arrey[i]) Console.WriteLine($"Есть число {num} на позиции {i}");
    if (num == arrey[i]) help = "Есть";
}
Console.WriteLine(help);