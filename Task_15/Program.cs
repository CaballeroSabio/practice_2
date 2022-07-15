// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Hi, User!");
Console.Write("Enter a number from 1 to 7: ");
int numberOfWeek = Convert.ToInt32(Console.ReadLine());
int[] arrayDayOfWeek = { 1, 2, 3, 4, 5, 6, 7 };
int count = arrayDayOfWeek.Length;

if (numberOfWeek <= count && numberOfWeek != 0)
{
    string DayOfWeek(int numberOfWeek)
    {
        string dayOfWeek = "null";
        if (numberOfWeek == arrayDayOfWeek[0]) dayOfWeek = "monday";
        if (numberOfWeek == arrayDayOfWeek[1]) dayOfWeek = "tuesday";
        if (numberOfWeek == arrayDayOfWeek[2]) dayOfWeek = "wednesday";
        if (numberOfWeek == arrayDayOfWeek[3]) dayOfWeek = "thursday";
        if (numberOfWeek == arrayDayOfWeek[4]) dayOfWeek = "friday";
        if (numberOfWeek == arrayDayOfWeek[5]) dayOfWeek = "saturday";
        if (numberOfWeek == arrayDayOfWeek[6]) dayOfWeek = "sunday";
        return dayOfWeek;
    }
    string dayOfWeek = DayOfWeek(numberOfWeek);
    // int indexOfHoliday1 = arrayDayOfWeek[5];
    // int indexOfHoliday2 = arrayDayOfWeek[6];
    if (numberOfWeek == arrayDayOfWeek[5] || numberOfWeek == arrayDayOfWeek[6])
    {
        Console.WriteLine($"this number is the number of the week -> {dayOfWeek}");
        Console.WriteLine("this day of the week is a holiday");
        Console.WriteLine("Great!");
    }
    else
    {
        Console.WriteLine($"this number is the number of the week -> {dayOfWeek}");
        Console.WriteLine("this day of the week is not a holiday");
    }
}
else
{
    Console.WriteLine("There is no such day of week");
}
Console.WriteLine("Goodbye, User!");
Console.WriteLine();