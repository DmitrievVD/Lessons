/*Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

// string NumberNext (int a, int num)
// {
//     if (a <= num) return $"{a} " + NumberNext(a + 1, num);
//     else return String.Empty;
// }

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(NumberNext(1,n));


/* Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */

string NumberNext (int a, int num)
{
    if (a <= num) return $"{a} " + NumberNext(a + 1, num);
    else return String.Empty;
}

Console.Write("Введите число (от): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число (до): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumberNext(m,n));




/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */




/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */




// Console.WriteLine("Hello, World!");
