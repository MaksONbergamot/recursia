// int Fact(int n)
// {
//     return n * Fact(n-1);
// }

// Fact(0);

//напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
// int SumOfDigits(int n) //через цикл
// {
//     int sum = 0;
//     while (n > 0)
//     {
//         sum += n % 10;
//         n /= 10;
//     } 
//     return sum;
// }

// int SumOfDigitsReq(int n) //через рекурсию
// {
//     if (n < 10)
//     {
//         return n;
//     }
//     int lastDigit = n % 10;
//     n /= 10;
//     return lastDigit + SumOfDigits(n);
// }
// Console.WriteLine(SumOfDigitsReq(135));



// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.

// Console.Write("Введите n: "); // Через цикл
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//     Console.Write(i + " ");
// }

// string PrintNumbers(int n) //через рекурсию (без введения n)
// {
//     if (n == 1)
//     {
//         return n.ToString();
//     }
//     return $"{n} {PrintNumbers(n - 1)}";
// }

// Console.WriteLine(PrintNumbers(15));



// 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());

void PrintNumbersMN(int start, int end)
{
    if (end > start)
    {
        PrintNumbersMN(start, end - 1);
    }
    Console.Write(end + " ");
}
if (m < n)
{
    PrintNumbersMN(m, n);
}
else
{
    PrintNumbersMN(n, m);
}


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.\
//Функция вывода массива


// int[] array = {5, 6, 3, 4, 8};
// Console.WriteLine(array[3]);
// static void ameba(int i)
// {
// Console.WriteLine(i);
// }

// int Fact(int n)
// {
//     if(n==1)
//     {
//         return 1;
//     }
//     return n * Fact(n-1);
// }

// Console.WriteLine(Fact(4));

int[] array = { 5, 6, 3, 4, 8 };
int Massive(int n = 5)
{
    if (n == 1)
    {
        return 1;
    }
    return    Console.WriteLine(array[n]);
    n++;
}
