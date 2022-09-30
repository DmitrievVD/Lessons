//  Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] arrey = new int [12];
int i = 0;
// Console.WriteLine("");

while (i < 12)
{
    arrey[i] = new Random().Next(-9, 9);
    Console.WriteLine($"{i} ||  {arrey[i]}");
    i++;
}
    Console.WriteLine($"");
    Console.WriteLine($"");
i = 0;
while (i < 12)
{
    if (arrey[i] > 0 ) 
    {
        arrey[i] = arrey[i] - (Math.Abs(arrey[i])*2);
    }
    else if (arrey[i] < 0 ) 
    {
        arrey[i] = arrey[i] + (Math.Abs(arrey[i])*2);
    }
    Console.WriteLine($"{i} ||  {arrey[i]}");
    i++;
}
