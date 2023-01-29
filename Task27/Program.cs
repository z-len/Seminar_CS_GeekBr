/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int GetSum(int num)
{
    int sum = 0;
    int tail = 0;
    while(num>0)
    {
        tail = num%10;
        sum +=tail;
        num = num/10;
       }
    return sum;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int summ = GetSum(number);
Console.WriteLine($" Cумма цифр {number} равна {summ}.");