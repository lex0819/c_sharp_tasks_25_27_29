/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int GetNumber(string message){
  bool isCorrect = false;
  int result = 0;

  while (!isCorrect)
  {
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine() , out result) && result > 0)
    {
      isCorrect = true;
    }
    else
    {
      Console.WriteLine("You've entered incorrect number, please try again");
    }
  }
  return result;
}

long RaisingToPower(int number, int power)
{
  long result = 1;

  for (int i = 1; i <= power; i++)
  {
    result *= number;
  }

  return result;
}

int number = GetNumber("Enter number A");
int power = GetNumber("Enter number B");
long res = RaisingToPower(number, power);

Console.WriteLine($"{number}, {power} -> {res}");