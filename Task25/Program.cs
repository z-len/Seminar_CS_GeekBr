/* Задача 25: Напишите функцию, которая принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.
Нельзя использовать библиотеку Math!
3, 5 -> 243 (3⁵)
2, 4 -> 16*/


int Stepen(int x, int y) 
{
    int result = 1;
    for (int i = 1; i <= y; ++i)
    {
       result *= x;
    }
    return result;
}

Console.Write("Введите число, которое надо возвести в степень: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите значение степени: ");
int b = int.Parse(Console.ReadLine());
int stepen = Stepen(a, b);
Console.WriteLine($"{a} ^ {b} = {stepen}");
