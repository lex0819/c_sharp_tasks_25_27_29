/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

string GetNumber(string message){
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
  return result.ToString();
}

int SummOfAllDigitals(string number){
  int summ = 0;
  int length = number.Length;
  for (int i = 0; i < length; i++)
  {
    int digit = Convert.ToInt32(number[i]-'0');  // Convert.ToInt32 переводит символ в число (точней сказать в юникод числа, поэтому мы отнимаем -'0' для того чтобы из юникода получить число)
    summ += digit;
  }
  return summ;
}

string number = GetNumber("Enter number");
int res = SummOfAllDigitals(number);
Console.WriteLine($"{number} -> {res}");