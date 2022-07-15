// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Hi, User!");
Console.Write("Enter an integer: ");
int inputInteger = Convert.ToInt32(Console.ReadLine());
string str = inputInteger.ToString();
int[] arrayOfInputInteger = new int[str.Length];
if (inputInteger > 99)
{
    for (int index = 0; index < str.Length; index++)
    {
        arrayOfInputInteger[index] = int.Parse(str[index].ToString());
    }
    Console.WriteLine($"The third digit of the given number is {arrayOfInputInteger[2]}");
    Console.WriteLine("Great!");
}
else
{
    Console.WriteLine("There is no third digit in the given number");
}
// Console.WriteLine($"The third digit of the given number is {arrayOfInputInteger[2]}");
Console.WriteLine("Goodbye, User!");
Console.WriteLine();