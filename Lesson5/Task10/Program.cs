﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int x = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int a;

a = x % 100 / 10;

Console.WriteLine(a);