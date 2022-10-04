// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] arr = new int [5];

int i = 0;
int score = 0;

while (i < arr.Length)
{
    Console.WriteLine($"Введите {i+1}е число: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}

for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] > 0) score += 1;
}
Console.WriteLine($"Количество положительных чисел: {score}");