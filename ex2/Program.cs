// Напишите программу, которая на вход принимает два числа A и B, и
//возводит число А в целую степень B с помощью рекурсии.
double Square(int a,int b)
{
    if (b==0) return 1;
    return Square(a,b-1)*a;
}
Console.Write("введите число:");
int a =int.Parse(Console.ReadLine()!);
int b=SumDigits(a);
Console.Write(b);