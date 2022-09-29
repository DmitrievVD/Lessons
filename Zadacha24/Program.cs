// Напишите программу которая принимает число (А), и выдает сумму чисел от 1 до А

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = 0;

for (int i = 0; i <= num; i++ )
{
    result = result + i;
    // Console.WriteLine(result);
}
Console.WriteLine($"Сумма чисел до числа {num}: {result}");