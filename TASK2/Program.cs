//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.//
Console.Clear();
Console.WriteLine("Введите число n :");
int n = Convert.ToInt32(Console.ReadLine());
  while (n >= 100)
{  
  Console.WriteLine($"Третья цифра = {n = n % 10}");
  return;
}
if (n < 100)
  Console.WriteLine("Третьей цифры нет");
