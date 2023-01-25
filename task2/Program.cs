// ... которая принимает на вход число и выдаёт кол-во цифр в числе.
// 456 -> 3
//78 -> 2
//89126 -> 5

Console.WriteLine(GetCountNum(new Random().Next(1000, 10000)));

static int GetCountNum(int num)
{
    Console.WriteLine(num);
    int count = 0;
    while(num > 0)
    {
        count++;
        num /= 10;
    }
    return count;
}