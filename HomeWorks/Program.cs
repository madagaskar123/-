﻿
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/*

Console.WriteLine ($" Input First number ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input Second number");

int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
 {
 
  Console.WriteLine($"max number is {num1} and min number is {num2}");
 }

  else if (num1 < num2 )
  {
    Console.WriteLine($"max number is {num2} and min number is {num1}");

}
else 
{
Console.WriteLine($"{num1} is equals {num2} ");

}

*/



//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 2

/*


Console.WriteLine ($" Input First number ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input Second number");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input Third number");

int num3 =Convert.ToInt32(Console.ReadLine());



if (num1 > num2 )
 {
   if (num1 > num3)
    {
     Console.WriteLine($"max number is {num1}");

    }

     else  Console.WriteLine($"max number is {num3}");
 }

  else if (num2 > num1 )
  {

    if (num2 > num3)


     Console.WriteLine($"max number is {num2}");

     else Console.WriteLine($"max number is {num3}");


}

*/



//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число 
//чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

/*

Console.WriteLine ($" Input number ");

int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0 )
{
Console.WriteLine($"{num}  четное ");
}
else Console.WriteLine($"{num} нечетное");

*/ 


//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Input Number");

int num = Convert.ToInt32(Console.ReadLine());

int current = num / num + 1;

while (current <= num)

{
 Console.Write(current + " ");
 current += 2;
}



















/* **Задача 1:** Напишите программу, которая принимает на вход пятизначное число и проверяет, является 
ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

**Задача 2:** Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

формула l^2 = (x2-x1)^2+(y2-y1)^2+(z2-z1)^2


**Задача 3:** Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125





     




























//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8


/***Задача 1:** Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **вторую** цифру этого числа.

456 -> 5
782 ->  8
918  -> 1

**Задача 2:** Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

**Задача 3:** Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 ->  да
1 -> нет

console.WriteLine($"input num = a , num = b");*/