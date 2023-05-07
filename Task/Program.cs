//  Задача: Написать программу, которая из имеющегося массива строк формирует
//  новый массив из строк, длина которых меньше, либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void FormNewArray(string[] firstarray, string[] secondarray)
{
  int count = 0;
  for (int i = 0; i < firstarray.Length; i++)
    {
       if(firstarray[i].Length <= 3)
        {
        secondarray[count] = firstarray[i];
        count++;
        }
    
  if (firstarray[i].Length > 3)
       {
       Console.WriteLine("[]");
       }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
     Console.WriteLine();
}
string[] firstarray = new string[4] {"Hello", "2", "world", ":-)"};
string[] secondarray = new string[firstarray.Length];
FormNewArray(firstarray, secondarray);
PrintArray(secondarray);

