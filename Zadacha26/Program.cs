// Напишите программу которая принимает на вход число и выдает количество цифр в числе.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int score = 0;
int i = num;
while (i > 0)
{
    i = i / 10;
    score++;
    // Console.WriteLine($"{i} || {score}");
}
Console.WriteLine($"Цифр в числе {num}: {score}");