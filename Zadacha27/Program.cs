// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int[] arr = new int[10];

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int num = n;
int i = num;
int index = -1;
int result = 0;
while (i > 0)
{
    num = i % 10;
    i = i/10;
    index = index + 1;
    arr[index] = num;
    // Console.WriteLine($"{num} || {i} || {index}");
    // Console.WriteLine(arr[index]);
}
while (index > -1)
{
    result = result + arr[index];
    index = index -1;
}

Console.WriteLine($"Сумма цифр числа {n} равен: {result}");


// for (int f = 1; f <=10; f++ )
// {
//     Console.WriteLine(arr[f]);
// }

// Console.WriteLine($"Сумма цифр этого числа равен: {result}");


