//



int num1 = 7;
Console.WriteLine(GetSum(num1));
Console.WriteLine(GetSum(28));

static int GetSum(int num)
{
    int res = 0;
    for(int i = 1; i <= num; i++)
    {
        res += i;
    }
    return res;
}