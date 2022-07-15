// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();
Console.WriteLine("Hi, User!");
Console.Write("Enter a three-digit number: ");
int digit = Convert.ToInt32(Console.ReadLine());
if (100 < digit && digit <= 999)
{
    static int secondDigit(int digit)
    {
        int result = digit / 10 % 10;
        return result;
    }
    int digit2 = secondDigit(digit);
    Console.WriteLine($"The second digit of this three-digit number is {digit2}");
    Console.WriteLine("Great!");
}
else
{
    Console.WriteLine("This number isn't three-digit");
}
Console.WriteLine("Goodbye, User!");
Console.WriteLine();
