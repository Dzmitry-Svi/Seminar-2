//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.//
Console.Clear();
Console.WriteLine("Введите трёхзначное число n :");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100 || n >= 1000)
  Console.WriteLine("Вы ввели не трёхзначное число, повторите попытку");
else 
  Console.WriteLine($"Второе число: {n = n / 10 % 10}");
