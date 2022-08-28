// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень B");
double B = Convert.ToDouble(Console.ReadLine());
double step = Math.Pow(A, B);
Console.WriteLine("A в степени B равно " + step);
