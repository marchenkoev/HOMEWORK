//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int n1, n2;

Console.Write("Введите число 1: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
n2 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{
    Console.Write($"max = {n1} min =  {n2}");
}
else
{
    Console.Write($"max = {n2} min = {n1}");
}

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int n1, n2, n3;

Console.Write("Введите число 1: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 3: ");
n3 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{
    Console.Write(n1);
}
else
if(n2 > n3)
{
   Console.Write(n2);  
}
else
{
     Console.Write(n3);
}

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int n1;

Console.Write("Введите число 1: ");
n1 = Convert.ToInt32(Console.ReadLine());

if(n1 % 2 == 0)
{
    Console.Write("да");
}
else
{
     Console.Write("нет");
}
