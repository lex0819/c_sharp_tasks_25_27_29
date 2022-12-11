/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

long GetNumber(string message){
  bool isCorrect = false;
  long result = 0;

  while (!isCorrect)
  {
    Console.WriteLine(message);
    if (Int64.TryParse(Console.ReadLine() , out result) && result > 0)
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


int[] CreateArrayDigits(long num)
{
  long number = num;
  List<int> arrayDigits = new List<int>();

  while( number > 10)
  {
    int mod = (int)number % 10;
    arrayDigits.Add(mod);
    number = number / 10;
  }
  arrayDigits.Add((int)number);

  return arrayDigits.ToArray();
}

int SummMathematic(int[] arrayDig)
{
  int summ = 0;
  int length = arrayDig.Length;
  
  for (int i = 0; i < length; i++)
  {
    summ += arrayDig[i];
  }

  return summ;
}

long number = GetNumber("Enter number");
int res = SummMathematic(CreateArrayDigits(number));
Console.WriteLine($"{number} -> {res}");