// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.

Console.WriteLine("Hello, World!");

int num = new Random ().Next(100,1000);
// int firstDigit = num/100;
// int secondDigit = num%10;
int dif (int num)
{
    int a = num/100;
    int b = num%10;
    int res = a*10+b;
}
Console.WriteLine($"{num}->{res}");