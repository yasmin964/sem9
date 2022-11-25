// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N.
void Sumnums(int numberM,int numberN,int sum)
{
   if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    Sumnums(numberM, numberN, sum);

}

Console.Write("введите число M:");
int numberM =int.Parse(Console.ReadLine()!);
Console.Write("введите число N:");
int numberN=int.Parse(Console.ReadLine()!);

Sumnums(numberM,numberN,1);
