﻿/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

string [] NameDay = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
string [] StatusDay = {"нет", "нет", "нет", "нет", "нет", "да", "да"};

Console.WriteLine("Введите порядковый номер дня недели: ");
int Number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{NameDay[(Number-1)]} является выходным? - {StatusDay[(Number-1)]}");