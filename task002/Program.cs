// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Решение.

Console.Clear();

Console.WriteLine("Введите первое занчение k1: ");
double k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите первое занчение b1: ");
double b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите первое занчение k2: ");
double k2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите первое занчение b2: ");
double b2 = int.Parse(Console.ReadLine()!);

const int x_cord = 0;
const int y_cord = 1;

if (k1 == k2)
{
  Console.WriteLine(" Если (х) кофициент одинаковый точки пересечения нет. Прямые паралельны.");
}
else
{
  double[] res = new double[2];
  res[x_cord] = (b1 - b2) / (k2 - k1);
  res[y_cord] = k1 * res[x_cord] + b1;
  Console.Write("Координаты точки пересечения -> ");
  Console.WriteLine(String.Join(" ", res));
}