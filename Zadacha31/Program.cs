// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].

int[] arrey = new int [12];
int i = 0;
// Console.WriteLine("");

while (i < 12)
{
    arrey[i] = new Random().Next(-9, 9);
    Console.WriteLine($"{i} ||  {arrey[i]}");
    i++;
}