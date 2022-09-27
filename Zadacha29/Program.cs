// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] arr = new int[10];
int i = 0;
int n = 0;
string help = "";
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

while (i < 10 )
{
    Console.Write($"Введите {i+1}е число: ");
    n = Convert.ToInt32(Console.ReadLine());
    arr[i] = n;
    // Console.WriteLine(arr[i]);
    Console.WriteLine("Если закончили напишите: стоп ");
    help = Console.ReadLine();
    if (help.ToLower() == "стоп") break;
    i++;
    // Console.WriteLine($"{num} || {i} || {index}");
}
for (int index = 0; index <= i; index = index + 1)
{
    Console.Write($"{arr[index]}, ");
}
