﻿/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите пятизначное число: ");
int x = int.Parse(Console.ReadLine());
int x1 = x/10000;
int x2 = x%10000/1000;
int x3 = x%1000/100;
int x4 = x%100/10;
int x5 = x%10;
if(x1==x5&&x2==x4)
{
    Console.Write($" Число {x} является палиндромом"); 
}
else
{
    Console.Write($" Число {x} не является палиндромом"); 
}