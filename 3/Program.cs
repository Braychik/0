﻿/*3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 -> Пятница */
Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int day = int.Parse(Console.ReadLine());
if(day == 1)
{ Console.WriteLine("Понедельник");}

if(day == 2)
{ Console.WriteLine("Вторник");}

if(day == 3)
{ Console.WriteLine("Среда");}

if(day == 4)
{ Console.WriteLine("Четверг");}

if(day == 5)
{ Console.WriteLine("Пятница");}

if(day == 6)
{ Console.WriteLine("Суббота");}

if(day == 7)
{ Console.WriteLine("Воскресенье");}

/* можно было сделать просто так 
if(day == 1) Console.WriteLine("Понедельник");
if(day == 2) Console.WriteLine("Вторник");
if(day == 3) Console.WriteLine("Среда");
if(day == 4) Console.WriteLine("Четверг");
if(day == 5) Console.WriteLine("Пятница");*/