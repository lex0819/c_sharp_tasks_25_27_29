/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int GetNumber(string message){
  bool isCorrect = false;
  int result = 0;

  while (!isCorrect)
  {
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine() , out result))
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

int countOfItems = GetNumber("Please enter how many elements do you want in array");

int[] CreateArray(int howMany)
{
  int[] items = new int[howMany];

  for (int i = 0; i < howMany; i++)
  {
    items[i] = GetNumber("Please enter the next array element");
  }

  return items;
}


string output = string.Join(", ", CreateArray(countOfItems));
Console.WriteLine($"{output} -> [{output}]");
