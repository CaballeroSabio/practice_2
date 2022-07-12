//  Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23


Console.WriteLine("Enter an integer: ");
int Kratnoe(int num)
{
    int res1 = num%7;
    int res2 = num%23;
    if(res1==0 && res2==0) return 0;
    return num;
}

int digit