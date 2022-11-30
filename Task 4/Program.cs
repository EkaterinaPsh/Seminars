//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a <= b && b >= c) max = b;
else if (b <= a && a >= c) max = a;
else if (b <= c && c >= a) max = c;




Console.WriteLine("max = {0}", max);
Console.ReadLine();