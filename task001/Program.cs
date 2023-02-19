// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//Решение.

Console.Clear();

Console.WriteLine("Введите любые числа (они могут быть отрецательные или положительные) ");
Console.ForegroundColor = ConsoleColor.Yellow;
string[] numbers = Console.ReadLine()!.Split(new char[] { ' ' }); // Создаю массив из строки. Ввожу пользователем числа и разделяю их на подстроки.

int[] intsNumbers = Array.ConvertAll(numbers, s => int.TryParse(s, out int x) ? x : -1); // Преобразовываю строковый массив в числовой массив и исключаю в конце лишний пробел.

newNumbers(intsNumbers);

void newNumbers(int[] array)  // В данном методе нахожу числа которые больше ноля.
{
  int sum = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if (intsNumbers[i] > 0)
    {
      sum++;
    }
  }
  Console.ForegroundColor = ConsoleColor.Green;
  Console.Write("Количество чисел больше 0: -> ");
  Console.WriteLine(String.Join("", sum));
}
Console.ForegroundColor = ConsoleColor.White;