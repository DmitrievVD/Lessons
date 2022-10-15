/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

// string NumScore(int n)
// {
//     if (n == 1) return "1";
//     else return $"{n} " + NumScore(n-1);
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string x = NumScore(num);
// Console.WriteLine(x);



/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

// int NumdersSumFromeBefor(int frome, int before)
// {
//     if (frome == before) return before;
//     else return frome + NumdersSumFromeBefor(frome + 1, before);
// }
// Console.Write("Введите число(от): ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число(до): ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// int sum = NumdersSumFromeBefor(n1,n2);
// Console.WriteLine(sum);


/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int Akkerman (int m, int n)
{
    if (m == 0) return n+1;
    else if (m > 0 & n == 0) return Akkerman(m - 1, 1);
    else if (m > 0 & n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    else return 0;
}

Console.Write("Введите число(m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число(n): ");
int n = Convert.ToInt32(Console.ReadLine());

int aker = Akkerman(m,n);
Console.WriteLine(aker);




// Console.WriteLine("Hello, World!");
