// Задача 68: Напишите программу вычисления функции Аккермана с помощью
//рекурсии. Даны два неотрицательных числа m и n. 
int Ackerman(int numberM, int numberN)
{
   if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return Ackerman(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return Ackerman(numberM - 1, Ackerman(numberM, numberN - 1));
return Ackerman(numberM, numberN);
}
Console.Write("введите число M:");
int numberM =int.Parse(Console.ReadLine()!);
Console.Write("введите число N:");
int numberN=int.Parse(Console.ReadLine()!);
Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {Ackerman(numberM, numberN)}");