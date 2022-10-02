// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Задача 41 ");
Console.WriteLine ("Введите числа:");
Console.WriteLine ("Ввод чисел останавливается при помощи STOP");

int countOfPositive = 0;

while (true)
{
  string answer = Console.ReadLine();
  if (answer == "STOP")
  {
    break;
  }
  else
  {
    int answerNumber = Convert.ToInt32(answer);
    if (answerNumber > 0)
    {
      countOfPositive++;
    }
  }
}
Console.WriteLine($"Количество чисел больше 0: "); 
Console.WriteLine(countOfPositive); 